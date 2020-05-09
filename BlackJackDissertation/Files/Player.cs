using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackDissertation.Files
{
    public class Player
    {
        // members and properties

        private Card[] _cards;
        private int _playerTotal;
        private int _cardAmmount;

        // constructors

        public Player()
        {
            _cards = new Card[5]; // an Array of the card class that represents the hand of five cards
            _playerTotal = 0; // the users current total at the end of the hand
            _cardAmmount = 0; // the ammount of cards during the current state of the game

        }

        // methods 

        /// <summary>
        /// if the user has not reached the maximium ammount of cards drawn then a a card will be added until it reaches the value of 5
        /// </summary>
        /// <param name="card"></param>
        public void AddCard(Card add)
        {
            if (_cardAmmount < 5)
            {
                _cards[_cardAmmount] = add;
                _cardAmmount++;
            }
            UpdateHand();
        }

        /// <summary>
        /// updates the current value of the players hand 
        /// </summary>
        public void UpdateHand()
        {
            _playerTotal = 0;
            for (int i = 0; i < _cardAmmount; i++)
            {
                _playerTotal += _cards[i].GetValue();
            }
        }

        // Get and Setters

        #region Getters and Setters

        public void SetCard(Card[] cards)
        {
            this._cards = cards;
        }

        public Card[] GetCard()
        {
            return _cards;
        }

        public void SetPlayerTotal(int playertotal)
        {
            this._playerTotal = playertotal;
        }

        public int GetPlayerTotal ()
        {
            return _playerTotal;
        }

        public void SetCardAmmount(int cardAmmount)
        {
            this._cardAmmount = cardAmmount;
        }

        public int GetCardAmmount()
        {
            return _cardAmmount;
        }

        #endregion
    }
}
