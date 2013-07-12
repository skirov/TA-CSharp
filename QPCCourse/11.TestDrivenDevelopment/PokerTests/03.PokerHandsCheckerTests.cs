using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Poker;

namespace PokerTests
{
    [TestClass]
    public class PokerHandsCheckerTests
    {
        #region IsValid() method tests

        [TestMethod]
        public void TestIsValid_HandWithSixDifferentCards_ReturnsFalse()
        {
            List<ICard> sixCards = new List<ICard>();

            sixCards.Add(new Card(CardFace.Ace, CardSuit.Clubs));
            sixCards.Add(new Card(CardFace.Two, CardSuit.Diamonds));
            sixCards.Add(new Card(CardFace.Three, CardSuit.Hearts));
            sixCards.Add(new Card(CardFace.Four, CardSuit.Spades));
            sixCards.Add(new Card(CardFace.Five, CardSuit.Spades));
            sixCards.Add(new Card(CardFace.Six, CardSuit.Spades));

            Hand newHand = new Hand(sixCards);

            PokerHandsChecker game = new PokerHandsChecker();

            Assert.AreEqual(false, game.IsValidHand(newHand));
        }

        [TestMethod]
        public void TestIsValid_HandWithFourDifferentCards_ReturnsFalse()
        {
            List<ICard> fourCards = new List<ICard>();

            fourCards.Add(new Card(CardFace.Ace, CardSuit.Clubs));
            fourCards.Add(new Card(CardFace.Two, CardSuit.Diamonds));
            fourCards.Add(new Card(CardFace.Three, CardSuit.Hearts));
            fourCards.Add(new Card(CardFace.Four, CardSuit.Spades));

            Hand newHand = new Hand(fourCards);

            PokerHandsChecker game = new PokerHandsChecker();

            Assert.AreEqual(false, game.IsValidHand(newHand));
        }

        [TestMethod]
        public void TestIsValid_HandWithFiveDifferentCards_ReturnsTrue()
        {
            List<ICard> fourCards = new List<ICard>();

            fourCards.Add(new Card(CardFace.Ace, CardSuit.Clubs));
            fourCards.Add(new Card(CardFace.Two, CardSuit.Diamonds));
            fourCards.Add(new Card(CardFace.Three, CardSuit.Hearts));
            fourCards.Add(new Card(CardFace.Four, CardSuit.Spades));
            fourCards.Add(new Card(CardFace.Ten, CardSuit.Spades));

            Hand newHand = new Hand(fourCards);

            PokerHandsChecker game = new PokerHandsChecker();

            Assert.AreEqual(true, game.IsValidHand(newHand));
        }

        [TestMethod]
        public void TestIsValid_HandWithFiveCards_TwoAreTheSame_ReturnsFalse()
        {
            List<ICard> fiveNotDifferentCards = new List<ICard>();

            fiveNotDifferentCards.Add(new Card(CardFace.Ten, CardSuit.Spades));
            fiveNotDifferentCards.Add(new Card(CardFace.Ace, CardSuit.Clubs));
            fiveNotDifferentCards.Add(new Card(CardFace.Two, CardSuit.Diamonds));
            fiveNotDifferentCards.Add(new Card(CardFace.Three, CardSuit.Hearts));
            fiveNotDifferentCards.Add(new Card(CardFace.Ten, CardSuit.Spades)); // the same as the first

            Hand newHand = new Hand(fiveNotDifferentCards);

            PokerHandsChecker game = new PokerHandsChecker();

            Assert.AreEqual(false, game.IsValidHand(newHand));
        }

        #endregion

        #region IsFlush() method tests

        [TestMethod]
        public void TestIsFlush_HandWithFiveCards_WithFourFromTheSameSuit_ReturnsFalse()
        {
            List<ICard> fiveCardsNoFlush = new List<ICard>();

            fiveCardsNoFlush.Add(new Card(CardFace.Ace, CardSuit.Hearts));
            fiveCardsNoFlush.Add(new Card(CardFace.Two, CardSuit.Hearts));
            fiveCardsNoFlush.Add(new Card(CardFace.Three, CardSuit.Hearts));
            fiveCardsNoFlush.Add(new Card(CardFace.Ten, CardSuit.Hearts));
            fiveCardsNoFlush.Add(new Card(CardFace.King, CardSuit.Spades)); //not Hearts

            Hand newHand = new Hand(fiveCardsNoFlush);

            PokerHandsChecker game = new PokerHandsChecker();

            Assert.AreEqual(false, game.IsFlush(newHand));
        }

        [TestMethod]
        public void TestIsFlush_HandWithFiveCards_ReturnsTrue()
        {
            List<ICard> fiveCards = new List<ICard>();

            fiveCards.Add(new Card(CardFace.Ace, CardSuit.Hearts));
            fiveCards.Add(new Card(CardFace.Two, CardSuit.Hearts));
            fiveCards.Add(new Card(CardFace.Three, CardSuit.Hearts));
            fiveCards.Add(new Card(CardFace.Ten, CardSuit.Hearts));
            fiveCards.Add(new Card(CardFace.King, CardSuit.Hearts)); //not Hearts

            Hand newHand = new Hand(fiveCards);

            PokerHandsChecker game = new PokerHandsChecker();

            Assert.AreEqual(true, game.IsFlush(newHand));
        }

        #endregion

        #region IsFourOfAKind() method tests

        [TestMethod]
        public void TestIsFourOfAKind_WithThreeEqualCars_ReturnsFalse()
        {
            List<ICard> fiveCardsNoFlush = new List<ICard>();

            fiveCardsNoFlush.Add(new Card(CardFace.Ace, CardSuit.Hearts));
            fiveCardsNoFlush.Add(new Card(CardFace.Ace, CardSuit.Diamonds));
            fiveCardsNoFlush.Add(new Card(CardFace.Ace, CardSuit.Spades));
            fiveCardsNoFlush.Add(new Card(CardFace.Ten, CardSuit.Clubs));
            fiveCardsNoFlush.Add(new Card(CardFace.King, CardSuit.Spades));

            Hand newHand = new Hand(fiveCardsNoFlush);

            PokerHandsChecker game = new PokerHandsChecker();

            Assert.AreEqual(false, game.IsFourOfAKind(newHand));
        }

        [TestMethod]
        public void TestIsFourOfAKind_WithFourEqualCars_ReturnsTrue()
        {
            List<ICard> fiveCardsNoFlush = new List<ICard>();

            fiveCardsNoFlush.Add(new Card(CardFace.Ace, CardSuit.Hearts));
            fiveCardsNoFlush.Add(new Card(CardFace.Ace, CardSuit.Diamonds));
            fiveCardsNoFlush.Add(new Card(CardFace.Ace, CardSuit.Spades));
            fiveCardsNoFlush.Add(new Card(CardFace.Ace, CardSuit.Clubs));
            fiveCardsNoFlush.Add(new Card(CardFace.King, CardSuit.Spades));

            Hand newHand = new Hand(fiveCardsNoFlush);

            PokerHandsChecker game = new PokerHandsChecker();

            Assert.AreEqual(true, game.IsFourOfAKind(newHand));
        }

        #endregion
    }
}
