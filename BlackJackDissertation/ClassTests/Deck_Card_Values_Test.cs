using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackDissertation.Files
{
    public class Deck_Card_Values_Test
    {



        int _value;
        Deck deck = new Deck();
        


       

        public bool Ace()
        {
            if (deck.GetRank() == "A")
            {
                deck.SetValue(11);
            }

            return true;
        }

      

        public bool Ace_Eqauls_11()
        {
            bool card;
            
            if (deck.GetRank() == "A")
            {
              card =  deck.DrawCard().GetValue() == 11;
            }
            return true;
 
        }

        public int Queen_Eqauls_10()
        {
            int value = 10;
            //deck.SetValue

            if(deck.GetRank() == "Q")
            {
                value = 10;
            }

            return value;
        }

        public int Test_Card_Values()
        {
            
            
            if(deck.GetRank() == "A")
            {
               _value = 11;
            }
            if (deck.GetRank() == "2")
            {
                SetValue(2);
            }
            if (deck.GetRank() == "3")
            {
                SetValue(3);
            }
            if (deck.GetRank() == "4")
            {
                SetValue(4);
            }
            if (deck.GetRank() == "5")
            {
                SetValue(5);
            }
            if (deck.GetRank() == "6")
            {
                SetValue(6);

            }

            return GetValue();
        }

       




        public void SetValue(int value)
        {
            this._value = value;
        }

        public int GetValue()
        {
            return _value;
        }
    }
}
