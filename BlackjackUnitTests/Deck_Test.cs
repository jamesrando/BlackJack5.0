using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackJackDissertation;
using BlackJackDissertation.Files;
using System.Drawing;
using System.Collections.ObjectModel;

namespace BlackjackUnitTests
{
    [TestClass]
    public class Deck_Test
    {
        /// <summary>
        /// test if both ranks equal the same rank
        /// </summary>
        [TestMethod]
        public void AceIsDrawn_ReturnsFalse()
        {
            // Arrange
            Deck deck = new Deck();
            bool kingRank = deck.DrawCard().GetRank() == "K";
            bool aceRank = deck.DrawCard().GetRank() == "A";

            // Act
            bool test = kingRank = aceRank;

            // Assert
            bool exspectedOutcome = false;

            Assert.AreEqual(test, exspectedOutcome);
        }


       
        /// <summary>
        /// Tests if the card rank is eqaull to ace
        /// </summary>
        [TestMethod]
        public void Ace_Equal_Rank()
        {
            Deck deck = new Deck();
            Deck_Card_Values_Test cardValues = new Deck_Card_Values_Test();

            bool test = deck.DrawCard().GetRank() == "A";

            bool actual = cardValues.Ace();

            
            bool expected = true;



            // act

            Assert.AreEqual(actual, expected);
            
        }

        /// <summary>
        /// Tests if ace is equall to 11
        /// </summary>
        [TestMethod]
        public void Ace_Equal_Value()
        {
            Deck deck = new Deck();
            Deck_Card_Values_Test cardValues = new Deck_Card_Values_Test();

        
            

            bool actual =  cardValues.Ace_Eqauls_11();
            bool expected = true;



            // act

            Assert.AreEqual(expected, actual);

        }
        /// <summary>
        /// tests queen value equals to 10
        /// </summary>
        [TestMethod]
        public void Queen_Equal_Value()
        {
            Deck deck = new Deck();
            Deck_Card_Values_Test cardValues = new Deck_Card_Values_Test();

            int actual = cardValues.Queen_Eqauls_10();
            int expected = 10;

            // act

            Assert.AreEqual(expected, actual);

        }

        /// <summary>
        /// Test that array matches suit values 
        /// </summary>
        [TestMethod]
        public void Check_Array_Suit_Values()
        {
            // Arrange
            Deck deck = new Deck();
            Array expected = new[] { "H", "D", "S", "C" };
            Array actual;

            // Act
            actual = deck.GetSuitArray();

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test array matches suit values
        /// </summary>
        [TestMethod]
        public void Check_Array_Rank_Values()
        {
            // Arrange
            Deck deck = new Deck();
            Array expected = new[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            Array actual;

            // Act
            actual = deck.GetRankArray();

            // Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
