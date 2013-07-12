using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;
using System.Collections.Generic;

namespace PokerTests
{
    [TestClass]
    public class HandTests
    {
        [TestMethod]
        public void TestHand_ToString()
        {
            List<ICard> fiveCards = new List<ICard>();

            fiveCards.Add(new Card(CardFace.Ace, CardSuit.Clubs));
            fiveCards.Add(new Card(CardFace.Two, CardSuit.Diamonds));
            fiveCards.Add(new Card(CardFace.Three, CardSuit.Hearts));
            fiveCards.Add(new Card(CardFace.Four, CardSuit.Spades));
            fiveCards.Add(new Card(CardFace.Five, CardSuit.Spades));

            Hand newHand = new Hand(fiveCards);

            Assert.AreEqual("A♣2♦3♥4♠5♠", newHand.ToString());
        }
    }
}
