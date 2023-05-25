using System;
using System.Collections.Generic;
using System.Linq;
using MoreLinq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace CartagenaBuenaventura.Classes
{
    public class Robot
    {
        private Match match;
        private Player player;
        
        public Robot(Match match) 
        { 
            this.match = match;
            this.player = this.match.user;
        }

        public async Task<bool> Verifying()
        {
            bool isUserTurn = await Game.VerifyUserTurn(this.match);

            if (isUserTurn) 
            {
                /* FOR VIEWING ONLY */
                Console.WriteLine("Seu turno");
                // 

                List<Locus> pawns = getPawns();

                /* FOR VIEWING ONLY */
                Console.WriteLine("Meus peos");
                foreach (Locus move in pawns)
                {
                    Console.WriteLine($"{move.position}");
                }
                //

                for (int turn = 0; turn < 2; turn++)
                {
                    Locus position = pawns.OrderBy(move => move.position).FirstOrDefault();

                    this.player.GoFoward(Convert.ToInt32(position.position), 
                        this.player.ShowHand(this.player.id, this.player.password).FirstOrDefault());
                }
                pawns = getPawns();
                Locus positions = pawns.OrderByDescending(move => move.position).FirstOrDefault();
                this.player.GoBack(Convert.ToInt32(positions.position));

                /* FOR VIEWING ONLY */
                Console.WriteLine("Historico");
                List<Move> history = Game.History(this.match);
                foreach (Move move in history)
                {
                    Console.WriteLine($"{move.player.id}, {move.origin}, {move.destination}, {move.card}");
                }
                //

            }

            return true;
        }

        private List<Locus> getPawns()
        {
            List<Locus> pawns = new List<Locus>();

            List<Locus> statusBoard = Game.BoardSituation(this.match);
            foreach (Locus pawn in statusBoard) 
            { 
                if (pawn.player.id == this.player.id)
                {
                    for(int i = 0; i < pawn.amount; i++)
                    {
                        pawns.Add(new Locus
                        {
                            position = pawn.position,
                            player = this.player,
                            amount = 1
                        });
                    }
                }

            }

            return pawns;
        }
    }
}
