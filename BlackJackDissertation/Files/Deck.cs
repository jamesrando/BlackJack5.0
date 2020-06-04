using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackDissertation.Files
{
    public class Deck
    {
        // members and properties

        private Card[] _deck; // an Array of the card class which is going to be the creation of multiple cards
        private int _nextCard; // will determine what the next card is going to be pulled from the deck of cards
        private int _suit;  // represents each suit value that will be included in the deck of cards
        private string _rank; // represents each rank value that will be included in the deck of cards
        private int _value; // represents each value of the cards that will be included in the deck of cards

        // testing array values
        Array  _aRanks = new [] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        Array  _aSuits = new [] { "H", "D", "S", "C" };


        // constructor

        public Deck()
        {
            // sets the ranks and suits of the varations of playing cards within two arrays
            string[] ranks = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            string[] suits = { "H", "D", "S", "C" };
            int position = 0;

            // Creation of the deck of cards that will be used
            // an array of cards that will equal the deck ammount of 6
            _deck = new Card[312];
            for (int deckNumber = 0; deckNumber < 6; deckNumber++)
            {
                // the four suits that are used in a deck of cards
                for (int suitNumber = 0; suitNumber < 4; suitNumber++)
                {
                    // the 13 ranks that will be required in a deck of cards
                    for (int rankNumber = 0; rankNumber < 13; rankNumber++)
                    {
                        //Set the filename of the image based on the above information
                        string imageName = "BlackJackDissertation.Cards." + ranks[rankNumber] + suits[suitNumber] + ".jpg";

                        // gathers local resource of the card images folder
                        Assembly myAssembly = Assembly.GetExecutingAssembly();
                        Stream myStream = myAssembly.GetManifestResourceStream(imageName);
                        Bitmap bmp = new Bitmap(myStream);

                        // Sets each value of the card values that will be required
                        int value;
                        if (rankNumber == 0)
                        {
                            value = 11;
                        }
                        else if (rankNumber > 0 && rankNumber < 9)
                        {
                            value = rankNumber + 1;
                        }
                        else
                        {
                            value = 10;
                        }
                       // Initialize of the card class which creates the deck
                       Card newCard = new Card(suitNumber, ranks[rankNumber], value, bmp, Properties.Resources.cardback);
                       _deck[position] = newCard;
                        position++;
                    }
                }
            }
            _nextCard = 0;
        }

        //Methods
        
        /// <summary>
        /// Shuffles the array of cards so that it replicates the shuffle system in blackjack rules
        /// </summary>
        public void ShuffleDeck()
        {
            Random rand = new Random(); // use of the random class to create shuffle mechanic 

            //Takes each card and randomly swaps it with another in the array
            for (int first = _nextCard; first < (_deck.Count() - _nextCard); first++)
            {
                //Randomly select a second card
                int second = rand.Next(_deck.Count() - _nextCard);
                //Swap the cards
                Card temp = _deck[first];
                _deck[first] = _deck[second];
                _deck[second] = temp;
            }
            _nextCard = 0;
        }

        
        /// <summary>
        /// draws card from the deck and makes sure that aces are set to 11
        /// </summary>
        public Card DrawCard()
        {
            Card drawCard = _deck[_nextCard];
            //Makes sure all aces have 11 value to start with rather than the value of 1
            if (drawCard.GetRank() == "A")
            {
                drawCard.SetValue(11);
            }
            _nextCard++;
            //If deck gets too small, shuffles it again
            if (_deck.Length - _nextCard < 26)
            {
                ShuffleDeck();
            }
            return drawCard;
        }

    
       
        //Getters and setters
        #region Getters and Setters

        public void SetDeck(Card[] deck)
        {
            this._deck = deck;
        }

        public Card[] GetDeck()
        {
            return _deck;
        }

        public void SetNextCard(int topCardIndex)
        {
            this._nextCard = topCardIndex;
        }

        public int GetNextCard()
        {
            return _nextCard;
        }


        public void SetSuit(int suit)
        {
            this._suit = suit;
        }

        public int GetSuit()
        {
            return _suit;
        }

        public void SetRank(string rank)
        {
            this._rank = rank;
        }

        public string GetRank()
        {
            return _rank;
        }

        public void SetValue(int value)
        {
            this._value = value;
        }

        public int GetValue()
        {
            return _value;
        }

        public int SetCardValue(int value)  
        {
            return _value;
        }

        public Array GetSuitArray() 
        {
            return _aSuits;
        }

        public Array GetRankArray()
        {
            return _aRanks;
        }
        #endregion
    }

  
   
}
