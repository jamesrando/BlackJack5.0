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
    class Deck
    {
        // members and properties

        private Card[] _deck; // an Array of the card class which is going to be the creation of multiple cards
        private int _nextCard; // will determine what the next card is going to be pulled from the deck of cards

        // constructors

        public Deck()
        {
            // sets the ranks and suits of the varations of playing cards within two arrays
            string[] ranks = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            string[] suits = { "H", "D", "S", "C" };
            int position = 0;

            //Builds new deck
            //Creates 6 'Standard decks' (52 cards)
            _deck = new Card[312];
            for (int deckNumber = 0; deckNumber < 6; deckNumber++)
            {
                //Each of the four suits
                for (int suitNumber = 0; suitNumber < 4; suitNumber++)
                {
                    //Each of the thirteen ranks
                    for (int rankNumber = 0; rankNumber < 13; rankNumber++)
                    {
                        //Set the filename of the image based on the above information
                        string imageName = "BlackJackDissertation.Cards." + ranks[rankNumber] + suits[suitNumber] + ".jpg";

                        //Load the image from local resource
                        Assembly myAssembly = Assembly.GetExecutingAssembly();
                        Stream myStream = myAssembly.GetManifestResourceStream(imageName);
                        Bitmap bmp = new Bitmap(myStream);

                        //Determine the value of the card
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
                       // Create the card and add it to deck
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
            Random rand = new Random();

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
            //Makes sure all aces have 11 value to start with (in case it has been changed and shuffled back in)
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

        #endregion
    }


}
