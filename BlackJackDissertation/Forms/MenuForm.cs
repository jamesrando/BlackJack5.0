using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackDissertation.Forms
{
    public partial class MenuForm : Form
    {
        // member variables 

        public static GameForm gameForm = new GameForm(); // new instance of game form




        public MenuForm()
        {
            InitializeComponent();
        }

        // Creates a new blackjack game and opens the game form 

        private void button1_Click(object sender, EventArgs e)
        {
            gameForm.Show();
            this.Hide();
            gameForm.hitBtn.Tag = "BetPhase";
            gameForm.UpdateUI();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_rules_Click(object sender, EventArgs e)
        {
            string header = "BlackJack Rules";
            string message = "\nWelcome to my Blackjack Player" +
                "\nThe aim of the game is to gain a score as close to the value of 21 without exceeding the value" +
                "\nDuring the Wager Phase you will be able to make an inital wager upto 1000" +
                "\nIf you do not have enough money in your bank ammount presented to the bottom right, you will not be able to place the wager" +
                "\nOnce Your wager has been accepted the Deal will begin" +
                "\nThe deal will present the intial two cards to your hand that will represent a numeric value" +
                "\nThis Value will be presented in the players score label ensure you know the current value of your cards" +
                "\nDuring the players turn you will be presented with two choices, Hit and Stand" +
                "\nIf you Hit an additional card will be added to your current hand, This will increase your hand value" +
                "\nIf you Choose to Stand, your current turn will be ended and the dealers cards will be revealed to the table" +
                "\nOnce both hands have been revealed to the table, the winner will be declared" +
                "\nBetting:" +
                "\nWhen a wager is made during the game, the dealer will match the bet" +
                "\nIf the player successfully wins the hand the player will recieve double there intial wager" +
                "\nIf the hand is lost, then  the inital wager will be taken and the game will return to the wager screen" +
                "\nBlackJack:" +
                "\nIf the players hand is the value of 21 with two cards, this will be a blackjack!" +
                "\nThe player will instantly win the hand and recieve double to wager with a bonus of half of the bet" +
                "\nCard Values:" +
                "\n All numeric cards such as 2-10 all represent there face value (5=5)" +
                "\n All Royals cards such as J,Q,K represent the value of 10" +
                "\n Aces can represent the value of 1 or 11, if the hand exceeds the total of 21 the ace will automatically represent the value of 1";

            MessageBox.Show(message, header);


        }
    }
}
