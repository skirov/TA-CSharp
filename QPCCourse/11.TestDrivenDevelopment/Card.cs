using System;
using System.Text;

namespace Poker
{
    public class Card : ICard
    {
        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();

            switch (Face)
            {
                case CardFace.Two:
                    toString.Append("2");
                    break;
                case CardFace.Three:
                    toString.Append("3");
                    break;
                case CardFace.Four:
                    toString.Append("4");
                    break;
                case CardFace.Five:
                    toString.Append("5");
                    break;
                case CardFace.Six:
                    toString.Append("6");
                    break;
                case CardFace.Seven:
                    toString.Append("7");
                    break;
                case CardFace.Eight:
                    toString.Append("8");
                    break;
                case CardFace.Nine:
                    toString.Append("9");
                    break;
                case CardFace.Ten:
                    toString.Append("10");
                    break;
                case CardFace.Jack:
                    toString.Append("J");
                    break;
                case CardFace.Queen:
                    toString.Append("Q");
                    break;
                case CardFace.King:
                    toString.Append("K");
                    break;
                case CardFace.Ace:
                    toString.Append("A");
                    break;
                default:
                    break;
            }

            switch (Suit)
            {
                case CardSuit.Clubs:
                    toString.Append("♣");
                    break;               
                case CardSuit.Diamonds:  
                    toString.Append("♦");
                    break;
                case CardSuit.Hearts:
                    toString.Append("♥");
                    break;
                case CardSuit.Spades:
                    toString.Append("♠");
                    break;
                default:
                    break;
            }

            return toString.ToString();
        }
    }
}
