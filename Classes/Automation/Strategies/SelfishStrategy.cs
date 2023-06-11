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
        highest,
        lowest
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
            int position = choosePosition(Select.lowest);
            string card = chooseCard(Select.highest);

            return (position, card);
        }

        private (int, string) moveBack()
        {
            int position = choosePosition(Select.highest);

            return (position, "");
        }

        private string chooseCard(Select select)
        {
            List<(string card, int count)> cards = this.player.ShowHandCounting();
            (string symbol, int count) card = cards.FirstOrDefault();

            if (select == Select.highest)
            {
                foreach (var each in cards)
                {
                    if (each.count > card.count)
                    {
                        card = each;
                    }
                }
            }
            else // if (select == Select.lowest)
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

        private int choosePosition(Select select)
        {
            Locus position;

            if (select == Select.highest)
            {
                position = getPawns(this.player).OrderByDescending(move => move.position).FirstOrDefault();
            }
            else // if (select == Select.lowest)
            {
                position = getPawns(this.player).OrderBy(move => move.position).FirstOrDefault();
            }

            return Convert.ToInt32(position.position);
        }
    }
}
