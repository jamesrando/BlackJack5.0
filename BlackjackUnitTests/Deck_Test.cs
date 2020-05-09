using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BlackJackDissertation;
using BlackJackDissertation.Files;
using System.Drawing;

namespace BlackjackUnitTests
{
    [TestClass]
    public class Deck_Test
    {



        /// <summary>
        /// tests to see if rank ace is equal to IsAce method that sets the Ace card to correct rank
        /// </summary>
       /* [TestMethod]
        public void AceIsDrawn_ReturnsTrue()
        {
            // arrange
            Deck deck = new Deck();
            bool aceRank = deck.DrawCard().GetRank() == "A";
            bool test = aceRank = deck.IsAce();
            bool expectedIsAce = true;

            Assert.AreEqual(expectedIsAce, test);
        }*/
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

        [TestMethod]
        public void Three_Equal_Value()
        {
            Deck deck = new Deck();
            Deck_Card_Values_Test cardValues = new Deck_Card_Values_Test();




            string actual = cardValues.Test_Card_Values("3");
            int expected = 3;



            // act

            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Thre_Equal_Value()
        {
            Deck deck = new Deck();
            Deck_Card_Values_Test cardValues = new Deck_Card_Values_Test();




            int actual = cardValues.Test_Card_Values();
            int expected = 3;



            // act

            Assert.AreEqual(expected, actual);

        }
    }
}
