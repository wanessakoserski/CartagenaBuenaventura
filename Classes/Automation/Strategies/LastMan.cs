using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartagenaBuenaventura.Classes.Automation.Strategies
{
    internal class LastMan : Strategy
    {
        private List<Locus> boardState;
        public LastMan(Match match) : base(match) 
        {
            boardState = Game.BoardSituation(match);
        }

        public override (int, string) makeMovement(int turn, int round)
        {
            // look the board situation, then chose the best possible strategy for the moment
            // (1) opportunist -> move back (preferably most advanced pawns) if there is an opportunity
            // (2) conservative -> move foward least advanced pawns
            // (3) desesperate -> move back most advanced pawns if there is few or no cards available
            
            //switch (round)  maybe not needed
            //{
            //    case 1:
            //        return;
            //    case 2:
            //        return;
            //    case 3:
            //        return;
            //    default:
            //        return;
            //}
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
    }
}
