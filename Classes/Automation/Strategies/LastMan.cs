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
    }
}
