using System;
using System.Collections.Generic;
using System.Linq;
using MoreLinq;
using System.Threading.Tasks;

namespace CartagenaBuenaventura.Classes
{
    public class Robot
    {
        private Match match;
        private Player player;
        private int myTurn;
        
        public Robot(Match match) 
        { 
            this.match = match;
            this.player = this.match.user;
            this.myTurn = 0;
        }

        // check if it is your current turn and if it is, execute the game strategy
        public async Task<bool> Verifying()
        {
            bool isUserTurn = await Game.VerifyUserTurn(this.match);

            if (isUserTurn) 
            {
                /* FOR VIEWING ONLY */
                Console.WriteLine("Seu turno");
                // 

                List<Locus> pawns = getPawns(this.player);

                /* FOR VIEWING ONLY */
                Console.WriteLine("Meus peos");
                foreach (Locus move in pawns)
                {
                    Console.WriteLine($"{move.position}");
                }
                //

                /* Implement Strategy */
                for (int turn = 1; turn <= 3; turn++)
                {
                    if(turn == 1 || turn == 2)
                    {
                        Locus position = pawns.OrderBy(move => move.position).FirstOrDefault();

                        this.player.GoFoward(Convert.ToInt32(position.position), 
                            this.player.ShowHand(this.player.id, this.player.password).FirstOrDefault());
                    } 
                    else
                    {
                        pawns = getPawns(this.player);
                        Locus positions = pawns.OrderByDescending(move => move.position).FirstOrDefault();
                        this.player.GoBack(Convert.ToInt32(positions.position));

                    }

                    this.myTurn++;
                }

                /* FOR VIEWING ONLY */
                Console.WriteLine("Historico");
                List<Move> history = Game.History(this.match);
                foreach (Move move in history)
                {
                    Console.WriteLine($"{move.player.id}, {move.origin}, {move.destination}, {move.card}");
                }
                //

            }

            await Task.Delay(1000);

            return true;
        }

        // return pawns position of the respective player
        private List<Locus> getPawns(Player p)
        {
            List<Locus> pawns = new List<Locus>();

            List<Locus> statusBoard = Game.BoardSituation(this.match);
            foreach (Locus pawn in statusBoard) 
            { 
                if (pawn.player.id == p.id)
                {
                    for(int i = 0; i < pawn.amount; i++)
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
