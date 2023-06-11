using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CartagenaBuenaventura.Classes.Automation.Strategies
{
    internal class LastMan : Strategy
    {
        private List<Locus> boardState;
        private List<Tile> board;
        private List<(string, int)> cards;
        List<Locus> pawns;

        public LastMan(Match match, List<Tile> board) : base(match)
        {
            //this.boardState = Game.BoardSituation(match);
            this.board = board;
            //cards = this.player.ShowHandCounting();
            //pawns = this.getPawns(this.player);
            //pawns.Sort((a, b) => b.position.CompareTo(a.position)); // sort in descending order
        }

        public override (int, string) makeMovement(int turn, int round)
        {
            // look the board situation, then chose the best possible strategy for the moment
            // (1) opportunist -> move back (preferably most advanced pawns) if there is an opportunity
            // (2) conservative -> move foward least advanced pawns
            // (3) desesperate -> move back most advanced pawns if there is few or no cards available


            this.cards = this.player.ShowHandCounting();
            this.boardState = Game.BoardSituation(match);
            this.pawns = this.getPawns(this.player);    // TODO: eliminar os que estão no barco
            this.pawns.Sort((a, b) => a.position.CompareTo(b.position)); // sort in ascendent order

            return this.EvaluateDecision();
        }

        // Evaluate the user pawns average position compared to the board average position
        // return the ration between the user and the whole board average pawns position
        private int AveragePosition(Dictionary<int, int> pAverage = null)
        {
            Dictionary<int, int> playersAverage = new Dictionary<int, int>();  // <id, average panws position>
            int boardAverage = 0;
            int totalPawns = 0;
            int i;

            for (i = 0; i < boardState.Count; i++)
            {
                totalPawns += boardState[i].amount;
                boardAverage += boardState[i].position * boardState[i].amount;
                if (playersAverage.ContainsKey((int)boardState[i].player.id))
                {
                    playersAverage[(int)boardState[i].player.id] += boardState[i].position * boardState[i].amount;
                }
                else
                {
                    playersAverage.Add((int)boardState[i].player.id, boardState[i].position * boardState[i].amount);
                }
            }

            int pawnsPerPlayer = totalPawns / match.players.Count;

            for (i = 0; i < match.players.Count; i++)
            {
                playersAverage[(int)match.players[i].id] /= pawnsPerPlayer;
            }

            if (pAverage != null) { pAverage = playersAverage; }
            boardAverage /= totalPawns;

            // value > 1 (above), value < 1 (bellow), value == 1 (average)
            if (boardAverage == 0) { return 1; }
            return (playersAverage[(int)match.user.id] / boardAverage);
        }

        // return a list (dictionary) of one tile of each symbol ahead of the position passed as param that have
        // atleast one pawn in it
        private Dictionary<string, List<int>> CheckPawnsAhead(int position)
        {
            List<(string symbol, int amount)> possibilities = new List<(string, int)>();    // amount of tiles in sequence of a symbol that have atlest one pawn in it
            //Dictionary<string, int> auxAhead = new Dictionary<string, int>();
            List<Locus> ahead = boardState.FindAll(locus => { return locus.position > position; });
            //Dictionary<string, int> tilesAhead = new Dictionary<string, int>();  // <symbol, position>
            Dictionary<string, List<int>> tilesAhead = new Dictionary<string, List<int>>();  // <symbol, positions>
            Dictionary<string, List<int>> auxTilesAhead = new Dictionary<string, List<int>>(tilesAhead);

            int i;

            for (i = position; (i < this.board.Count) /*&& (tilesAhead.Count < 6)*/; i++)
            {
                if (!tilesAhead.ContainsKey(board[i].symbol))
                {
                    tilesAhead.Add(board[i].symbol, new List<int>() { board[i].position });
                }
                else
                {
                    tilesAhead[board[i].symbol].Add(board[i].position);
                }
            }

            foreach (KeyValuePair<string, List<int>> tAhead in tilesAhead)
            {
                if (ahead.Find(x => x.position == tAhead.Value.First()) == null)
                {
                    auxTilesAhead.Remove(tAhead.Key);
                }
                else
                {
                    foreach (int pos in tAhead.Value)
                    {
                        if (ahead.Find(x => x.position == pos) == null)
                        {
                            tAhead.Value.RemoveRange(pos, tAhead.Value.Count);
                            break;
                        }
                    }
                }
            }

            foreach (KeyValuePair<string, List<int>> tAhead in auxTilesAhead)
            {
                auxTilesAhead[tAhead.Key] = tilesAhead[tAhead.Key];
            }

            return auxTilesAhead;

            //for (i = 0; i < ahead.Count; i++)
            //{
            //    auxAhead.Add(this.board[ahead[i].position].symbol, ahead[i].position);
            //}

            //for (i = 0; i < ahead.Count; i++)
            //{
            //    if (tilesAhead.ContainsValue(ahead[i].position))
            //    {
            //        tilesAhead.
            //        possibilities.Add(tilesAhead.First(x => x.Value == ahead[i].position).Key);
            //    }
            //}

            //for (i = 0; i < possibilities.Count; i++)
            //{
            //    List<Locus> auxAhead = ahead.FindAll(x => this.board[x.position].symbol == possibilities[i]);


            //}

            //return possibilities;
        }

        // return a list (positon, amount) of the the imediate n (n > 0) tiles behind the position passed as param
        // that have 2 or 1 pawn in it
        private List<(int, int)> CheckPawnsBehind(int position, int n)
        {
            List<(int position, int amount)> possibilities = new List<(int, int)>();
            List<Locus> behind = boardState.FindAll(locus => { return locus.position != 0 && locus.position < position; });
            Dictionary<int, int> tilesBehind = new Dictionary<int, int>();   // <position, number of pawns>

            for (int i = 0; i < behind.Count; i++)
            {
                if (!tilesBehind.ContainsKey(behind[i].position))
                {
                    tilesBehind.Add(behind[i].position, behind[i].amount);
                }
                else
                {
                    tilesBehind[behind[i].position] += behind[i].amount;
                }
            }

            foreach (KeyValuePair<int, int> x in tilesBehind)
            {
                if (x.Value < 3)    // less than 3 pawns on tile
                {
                    possibilities.Add((x.Key, x.Value));
                }
            }

            possibilities.Sort((a, b) => b.position.CompareTo(a.position));   // sort in descending order
            if (possibilities.Count < n) { return  possibilities; }
            else
            {
                possibilities.RemoveRange(n, possibilities.Count);
                return possibilities;
            }
            
            //return (List<(int position, int amount)>)possibilities.Take(n);
        }

        // Check if the last 3 pawns are close together or not. If so, check the best opportunity between them
        // to move foward, else retrive the best case scenario for the "last man" to move ahead
        private (int, string) OpportunitiesAhead()
        {
            (string, int) BestMove(int pawnPosition, List<string> cards)
            {
                (string symbol, int amount) bestOption = (null, -1);
                Dictionary<string, List<int>> tilesAhead = this.CheckPawnsAhead(pawns[0].position);

                foreach (KeyValuePair<string, List<int>> tile in tilesAhead)
                {
                    if ((cards.Contains(tile.Key)) && (tile.Value.Count > bestOption.amount))
                    {
                        bestOption = (tile.Key, tile.Value.Count);
                    }
                }

                return bestOption;
            }

            List<string> c = new List<string>();

            foreach ((string symbol, int amount) in cards)
            {
                c.Add(symbol);
            }

            if (pawns[1].position - pawns[0].position < 4)
            {
                List<(string symbol, int seqAmount)> moveOptions = new List<(string, int)>();
                int i = 0;

                if (pawns[2].position - pawns[1].position < 4)
                {
                    for (; i < 3; i++) { moveOptions.Add(BestMove(pawns[i].position, c)); }
                }
                else
                {
                    for (; i < 2; i++) { moveOptions.Add(BestMove(pawns[i].position, c)); }
                }

                //moveOptions.Sort((a, b) => b.Item2.CompareTo(a.Item2));
                (int pawn, int seqAmount) pawnWithBestOp = (0, 0);

                for (i = 0; i < moveOptions.Count; i++)
                {
                    if (moveOptions[i].seqAmount > pawnWithBestOp.seqAmount)
                    {
                        pawnWithBestOp = (i, moveOptions[i].seqAmount);
                    }
                }
                return (pawnWithBestOp.pawn, moveOptions[pawnWithBestOp.pawn].symbol);
            }
            else
            {
                return (0, BestMove(pawns[0].position, c).Item1);
            }
        }

        // Decides which one of the pawns from the user has the best opportunity to move back and buy cards, then
        // return its position
        private int OpportunityBehind()
        {
            List<(int, int)> auxBestOp;
            (int pawnPos, int amount) bestOpportunity = (0, 0);    // <position of the (user) pawn with the best opportunity to go back, amount of pawns behind it>

            for (int i = (pawns.Count - 1); i >= 0; i--)
            {
                auxBestOp = this.CheckPawnsBehind(pawns[i].position, 1);
                bestOpportunity = (bestOpportunity.amount < auxBestOp.First().Item2) ? (i, auxBestOp.First().Item2) : bestOpportunity;
            }

            return bestOpportunity.pawnPos;
        }

        //
        private (int, string) EvaluateDecision()
        {
            int averagePosition = this.AveragePosition();
            int numCards = cards.Count;

            bool lowNumCards = (numCards < 3);
            bool lowAvrgPosition = (averagePosition < 1);

            if (lowNumCards)
            {
                if (lowAvrgPosition)
                {
                    // look for oportunities
                    // if oportunities bad, then buy cards
                    (int, string) bestMoveOption = this.OpportunitiesAhead();
                    if (bestMoveOption.Item1 < 0 || bestMoveOption.Item2 == null)
                    {
                        //buy cards
                        return (this.OpportunityBehind(), "");
                    }
                    else
                    {
                        return bestMoveOption;
                    }
                }
                else
                {
                    // buy cards
                    return (this.OpportunityBehind(), "");
                }
            }
            else
            {
                if (lowAvrgPosition)
                {
                    // look oportunities
                    // advance
                    (int, string) bestMoveOption = this.OpportunitiesAhead();
                    if (bestMoveOption.Item1 < 0 || bestMoveOption.Item2 == null)
                    {
                        // check the type of cards with the biggest quantity and play it with the last man
                        cards.Sort((a, b) => b.Item2.CompareTo(a.Item2));   // sort cards by descending order of quantity
                        return (0, cards.First().Item1);
                    }
                    else
                    {
                        return bestMoveOption;
                    }

                }
                else
                {
                    // look for oportunities
                    // if oportunities bad, then buy cards
                    (int, string) bestMoveOption = this.OpportunitiesAhead();
                    if (bestMoveOption.Item1 < 0 || bestMoveOption.Item2 == null)
                    {
                        //buy cards
                        return (this.OpportunityBehind(), "");
                    }
                    else
                    {
                        return bestMoveOption;
                    }
                }
            }
        }
    }
}
