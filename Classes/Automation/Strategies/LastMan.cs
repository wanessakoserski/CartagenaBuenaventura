using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

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

            //return this.EvaluateDecision();
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
                playersAverage[(int)boardState[i].player.id] += boardState[i].position * boardState[i].amount;
            }

            int pawnsPerPlayer = totalPawns / match.players.Count;

            for (i = 0; i < match.players.Count; i++)
            {
                playersAverage[(int)match.players[i].id] /= pawnsPerPlayer;
            }

            if (pAverage != null) { pAverage = playersAverage; }
            boardAverage /= totalPawns;

            // value > 1 (above), value < 1 (bellow), value == 1 (average)
            return (playersAverage[(int)match.user.id] / boardAverage);
        }

        // return a list (dictionary) of one tile of each symbol ahead of the position passed as param that have
        // atleast one pawn in it
        private List<string> CheckPawnsAhead(int position)
        {
            List<string> possibilities = new List<string>();
            List<Locus> ahead = boardState.FindAll(locus => { return locus.position > position; });
            Dictionary<string, int> tilesAhead = new Dictionary<string, int>();  // <symbol, position>

            for (int i = position; (i < this.board.Count) && (tilesAhead.Count < 6); i++)
            {
                if (!tilesAhead.ContainsKey(board[i].symbol))
                {
                    tilesAhead.Add(board[i].symbol, board[i].position);
                }
                }

            for (int i = 0; i < ahead.Count; i++)
            {
                if (tilesAhead.ContainsValue(ahead[i].position))
                {
                    possibilities.Add(tilesAhead.First(x => x.Value == ahead[i].position).Key);
                }
                        }
            return possibilities;
        }

        // return a list (positon, amount) of the the imediate three tiles behind the position passed as param
        // that have 2 or 1 pawn in it
        private List<(int, int)> CheckPawnsBehind(int position)
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

            possibilities.Sort((a, b) => b.CompareTo(a));   // sort in descending order

            return (List<(int position, int amount)>)possibilities.Take(3);
        }
    }
}
