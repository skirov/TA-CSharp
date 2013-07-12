using System;
using System.Collections.Generic;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            if (hand.Cards.Count != 5)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < hand.Cards.Count; i++)
                {
                    for (int j = 0; j < hand.Cards.Count; j++)
                    {
                        if (hand.Cards[j].Face == hand.Cards[i].Face &&
                            hand.Cards[j].Suit == hand.Cards[i].Suit &&
                            i != j)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            //get the first card and check if three others are the same
            CardFace firstCardFace = hand.Cards[0].Face;
            byte counter = 0;

            for (int i = 0; i < hand.Cards.Count; i++)
            {
                if (hand.Cards[i].Face == firstCardFace)
                {
                    counter++;
                }
            }

            if (counter == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            //get the first card and check if others are the same
            CardSuit firstCardSuit = hand.Cards[0].Suit;

            for (int i = 0; i < hand.Cards.Count; i++)
            {
                if (hand.Cards[i].Suit != firstCardSuit)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
