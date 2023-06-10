using System;
using System.Collections.Generic;
using System.Linq;
using MoreLinq;
using System.Threading.Tasks;
using CartagenaBuenaventura.Classes.Automation;

namespace CartagenaBuenaventura.Classes
{
    public class Robot
    {
        private Match match;
        private Player player;
        private int turn;
        private Strategy strategy;
        
        public Robot(Match match) 
        { 
            this.match = match;
            this.player = this.match.user;
            this.turn = 0;
            this.strategy = new SelfishStrategy(this.match);
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
                for (int round = 1; round <= 3; round++)
                {
                    (int pawnPosition, string card) = strategy.makeMovement(this.turn, round);

                    if (pawnPosition >= 0 && card != "")
                        this.player.GoFoward(pawnPosition, card);
                    else if (pawnPosition >= 0)
                        this.player.GoBack(pawnPosition);
                    else
                        this.player.Skip();

                    this.turn++;
                }
                //

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
        /* ONLY STILL HERE FOR VIEWING */
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
