using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTests
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void TestCardToString_TwoOfSpades()
        {
            Card newCard = new Card(CardFace.Two, CardSuit.Spades);

            Assert.AreEqual("2♠", newCard.ToString());
        }

        [TestMethod]
        public void TestCardToString_AceOfHearts()
        {
            Card newCard = new Card(CardFace.Ace, CardSuit.Hearts);

            Assert.AreEqual("A♥", newCard.ToString());
        }

        [TestMethod]
        public void TestCardToString_QueenOfDiamonds()
        {
            Card newCard = new Card(CardFace.Queen, CardSuit.Diamonds);

            Assert.AreEqual("Q♦", newCard.ToString());
        }

        [TestMethod]
        public void TestCardToString_SevenOfClubs()
        {
            Card newCard = new Card(CardFace.Seven, CardSuit.Clubs);

            Assert.AreEqual("7♣", newCard.ToString());
        }
    }
}
