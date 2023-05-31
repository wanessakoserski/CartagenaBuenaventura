using MoreLinq.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartagenaBuenaventura.Classes.Automation
{
    enum Select
    {
        highestRepetition,
        lowestRepetition
    }

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

        private (int, string) moveForward()
        {
            Locus position = getPawns(this.player).OrderBy(move => move.position).FirstOrDefault();
            string card = chooseCard(Select.highestRepetition);

            return (Convert.ToInt32(position.position), card);
        }

        private (int, string) moveBack()
        {
            Locus position = getPawns(this.player).OrderByDescending(move => move.position).FirstOrDefault();

            return (Convert.ToInt32(position.position), "");
        }

        private string chooseCard(Select select)
        {
            List<(string card, int count)> cards = this.player.ShowHandCounting();
            (string symbol, int count) card = cards.FirstOrDefault();

            if (select == Select.highestRepetition)
            {
                foreach (var each in cards)
                {
                    if (each.count > card.count)
                    {
                        card = each;
                    }
                }
            }
            else
            {
                foreach (var each in cards)
                {
                    if (each.count < card.count)
                    {
                        card = each;
                    }
                }
            }

            return card.symbol;
        }
    }
}
