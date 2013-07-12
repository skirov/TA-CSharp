using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    public class Hand : IHand
    {
        public IList<ICard> Cards { get; private set; }

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();

            for (int i = 0; i < Cards.Count; i++)
            {
                toString.Append(Cards[i].ToString());
            }

            return toString.ToString();
        }
    }
}
