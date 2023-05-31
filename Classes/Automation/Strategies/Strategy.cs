using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartagenaBuenaventura.Classes.Automation
{
    internal abstract class Strategy
    {
        protected Match match;
        protected Player player;

        public Strategy(Match match)
        {
            this.match = match;
            this.player = match.user;
        }

        // default strategy logic initializer
        public abstract (int, string) makeMovement(int turn, int round);

        // return pawns position of the respective player
        protected List<Locus> getPawns(Player p)
        {
            List<Locus> pawns = new List<Locus>();

            List<Locus> statusBoard = Game.BoardSituation(this.match);
            foreach (Locus pawn in statusBoard)
            {
                if (pawn.player.id == p.id)
                {
                    for (int i = 0; i < pawn.amount; i++)
                    {
                        pawns.Add(new Locus
                        {
                            position = pawn.position,
                            player = p,
                            amount = 1
                        });
                    }
                }

            }

            return pawns;
        }
    }
}
