using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackDissertation.Files
{
    public class Card
    {

        // member variables / properties

        private int _suit; // will represent the four vararitons of suits for playing cards
        private string _rank; // will represent varations of ranks of the playing cards from Ace to King
        private int _value; // will represent the value of playing cards, all royals will act as 10 and Ace can be 1 or 11
        private Image _cardFace; // Front image of the playing card
        private Image _cardBack; // Back image of the playing card

        // constructor

        public Card(int suit, string rank, int value, Image cardFace, Image cardBack) // defines the card object
        {
            this._suit = suit;
            this._rank = rank;
            this._value = value;
            this._cardFace = cardFace;
            this._cardBack = cardBack;
        }

        
         
        // methods and get and setters
        #region Getters and Setters      
        public void SetSuit(int suit)
        {
            this._suit = suit;
        }

        public int GetSuit()
        {
            return this._suit;
        }

        public void SetRank(string rank)
        {
            this._rank = rank;
        }

        public string GetRank()
        {
            return this._rank;
        }

        public void SetValue(int value)
        {
            this._value = value;
        }

        public int GetValue()
        {
            return this._value;
        }

        public void SetCardFace(Image cardFace)
        {
            this._cardFace = cardFace;
        }

        public Image GetCardFace()
        {
            return this._cardFace;
        }

        public void SetCardBack(Image cardBack)
        {
            this._cardBack = cardBack;
        }

        public Image GetCardBack()
        {
            return this._cardBack;
        }

      
        #endregion Getters and Setters


























    }
}
