using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartagenaBuenaventura.Classes.Automation
{
    internal class SelfishStrategy : Strategy
    {
        public SelfishStrategy(Match match) : base(match) { }

        public override (int, string) makeMovement(int turn, int round)
        {
            switch (round)
            {
                case 1:
                    return moveForward();

                case 2:
                    return moveForward();

                case 3:
                    return moveBack();

                default:
                    return (-1 , "");
            }
        }

        /*
        private void moveForward()
        {
            Locus position = getPawns(this.player).OrderBy(move => move.position).FirstOrDefault();

            this.player.GoFoward(Convert.ToInt32(position.position),
                this.player.ShowHand(this.player.id, this.player.password).FirstOrDefault());
        }
        

        private void moveBack()
        {
            Locus positions = getPawns(this.player).OrderByDescending(move => move.position).FirstOrDefault();
            this.player.GoBack(Convert.ToInt32(positions.position));
        }
        */

        private (int, string) moveForward()
        {
            Locus position = getPawns(this.player).OrderBy(move => move.position).FirstOrDefault();
            string card = this.player.ShowHand(this.player.id, this.player.password).FirstOrDefault();

            return (Convert.ToInt32(position.position), card);
        }

        private (int, string) moveBack()
        {
            Locus position = getPawns(this.player).OrderByDescending(move => move.position).FirstOrDefault();
            string card = this.player.ShowHand(this.player.id, this.player.password).FirstOrDefault();

            return (Convert.ToInt32(position.position), "");
        }
    }
}
