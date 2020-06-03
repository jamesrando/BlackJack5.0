using BlackJackDissertation.Files;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackDissertation
{
    public partial class GameForm : Form
    {
        // member variables
        Blackjack newGame = new Blackjack();
        PictureBox[][] pictureBoxes;
        private int num = 0;



        public GameForm()
        {
            InitializeComponent();
            newGame.GetDeck().ShuffleDeck(); // shuffles the deck when the application is started
            pictureBoxes = new PictureBox[2][]
            {
                 new PictureBox[5] { playerCard1, playerCard2, playerCard3, playerCard4, playerCard5 },
                 new PictureBox[5] { dealerCard1, dealerCard2, dealerCard3, dealerCard4, dealerCard5 }
            };
           
        }



        /// <summary>
        /// if the hit button is clicked then the following is executed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void hitBtn_click(object sender, EventArgs e)
        {
          
                //Checks to see whan phase it is in, so the correct information can be displayed
                if ((string)hitBtn.Tag == "BetPhase")
                {
                //Place bet based on user input
                try {

                    if (newGame.Bet(Convert.ToInt32(betInput.Text)))
                    {
                        //Checks to see if it is the first bet of the game
                        if (newGame.GetGameStatus() == false)
                        {
                            //Cannot 'Walk Away' on first bet
                            newGame.SetGameStatus(true);
                            btn_stand.Visible = true;
                        }
                        hitBtn.Tag = "GamePhase";   //Changes phase
                        hitBtn.Text = "Hit";
                        UpdateUI();  // updates current ui
                        newGame.Deal();
                        //Updates display
                        DisplayHand("user");
                        lbl_player_score.Text = "Player Total\n" + newGame.GetPlayer().GetPlayerTotal();
                        lbl_dealer_score.Text = "Dealer Total\n" + newGame.GetDealer().GetCard()[1].GetValue(); // error when player gets blackjack
                    }
                    //If bet size is invalid, bet is not placed and text field is reset
                    else
                    {
                        betInput.Text = "";
                    } 
                }
                catch(Exception)
                {
                    MessageBox.Show("there is an issue with the current bet");
                }


                }
                else
                {
                    //User draws card
                    newGame.GetPlayer().AddCard(newGame.GetDeck().DrawCard());
                    if (newGame.GetPlayer().GetPlayerTotal() > 21)
                    {
                        //If user is going bust (over 21), checks to see if they Have any Aces that can have thier value counted as 1 instead of 11
                        for (int index = 0; index < newGame.GetPlayer().GetCardAmmount(); index++)
                        {
                            if (newGame.GetPlayer().GetCard()[index].GetRank() == "A" && newGame.GetPlayer().GetCard()[index].GetValue() == 11)
                            {
                                newGame.GetPlayer().GetCard()[index].SetValue(1);
                                break;
                            }
                        }
                    }
                    //Updates all info
                    newGame.GetPlayer().UpdateHand();
                    DisplayHand("user");
                    lbl_player_score.Text = "Player Total\n" + newGame.GetPlayer().GetPlayerTotal();
                    System.Threading.Thread.Sleep(1);
                    //If hand needs to be resolved without a dealer trun, goes straight to hand resolution (player blackjack, 5 card trick or bust)
                    if (newGame.GetPlayer().GetCardAmmount() == 5 || newGame.GetPlayer().GetPlayerTotal() > 21)
                    {
                        newGame.HandOutcome();
                    }
                    else if (newGame.GetPlayer().GetPlayerTotal() == 21)
                    {
                        newGame.DealerHand();
                    }
                }

            






        }
         
        private void Btn_stand_Click(object sender, EventArgs e)
        {
            if((string)btn_stand.Tag == "BetPhase")
            {
                MessageBox.Show("Players Turn Over, Dealers Hand");
                newGame.DealerHand();
                ;
            }
            else 
            {
                newGame.GameEnd();
            }
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// Displays cards to the pictureboxes to player and dealers hands
        /// </summary>
        /// <param name="player"></param>
        public void DisplayHand(string player)
        {
            for (int i = 0; i < newGame.GetPlayer().GetCardAmmount(); i++)
            {
                pictureBoxes[0][i].Visible = true;
                pictureBoxes[0][i].Image = newGame.GetPlayer().GetCard()[i].GetCardFace();
                pictureBoxes[0][i].Update();
            }

            for (int i = 0; i < newGame.GetDealer().GetCardAmmount(); i++)
            {
                pictureBoxes[1][i].Visible = true;
                if (i == 0 && player == "user")
                {
                    pictureBoxes[1][i].Image = newGame.GetDealer().GetCard()[i].GetCardBack();
                    pictureBoxes[1][i].Update();
                }
                else
                {
                    pictureBoxes[1][i].Image = newGame.GetDealer().GetCard()[i].GetCardFace();
                    pictureBoxes[1][i].Update();
                }
            }
        }
        /// <summary>
        /// updates the ui to the current part of the blackjack game
        /// </summary>
        public void UpdateUI()
        {
            // at the beginning of the game labels are default
            if ((string)hitBtn.Tag == "BetPhase")
            {
                
                hitBtn.Text = "Deal";
                btn_stand.Text = "Walk Away";
                btn_stand.Visible = false;


                pb_bet.Visible = true;
                lbl_bet_title.Visible = false;
                lbl_dealer_score.Visible = false;
                lbl_player_score.Visible = false;
                lbl_bet_ammount.Visible = false;// changed
                betInput.Visible = true;
                betInput.Text = "";
                lbl_wins.Text = "Wins:" + newGame.GetGameWin();
                lbl_loses.Text = "Loses: " + newGame.GetGameLoss().ToString();
                lbl_loses.Visible = true;

                pb_chip_50.Visible = true;
                pb_chip_100.Visible = true;
                pb_chip_500.Visible = true;
                btn_all_in.Visible = true;
                btn_reset.Visible = true;
                lbl_loses.Visible = true;
                pb_bet.Visible = false;
            }
            else
            {
                // during the game
                hitBtn.Text = "Hit";
                btn_stand.Text = "Stand";
                btn_stand.Visible = true;

                pb_bet.Visible = true;
                

                lbl_player_score.Visible = true;
                lbl_dealer_score.Visible = true;

                lbl_bet_title.Visible = false; // hidden during the game
                betInput.Visible = false;

                lbl_bet_ammount.Text = "Bet: £" + newGame.GetStake();
                lbl_loses.Text = "Loses: " + newGame.GetGameLoss().ToString();
                lbl_loses.Visible = true;

                lbl_bet_ammount.Visible = true;
                lbl_wins.Text = "Wins:" + newGame.GetGameWin();
                lbl_games.Text = "Games:" + newGame.GamesCount().ToString();
                lbl_wins.Visible = true;
                lbl_games.Visible = true;

                pb_chip_50.Visible = false;
                pb_chip_100.Visible = false;
                pb_chip_500.Visible = false;
                btn_all_in.Visible = false;
                btn_reset.Visible = false;
                
                
            }
            //hides player and dealers cards until they are required and updates players cash ammount
            lbl_bank_ammount.Text = "Bank: £" + newGame.GetBankAmmount();


            foreach (PictureBox[] pb in pictureBoxes) // hides pictureboxes
            {
                foreach (PictureBox pictureBox in pb)
                {
                    pictureBox.Visible = false;
                }
            }
        }
        
        /// <summary>
        /// Closes blackjack Application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void stake_input_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_stake_input_Click(object sender, EventArgs e)
        {

        }

        private void pb_chip_stake_Click(object sender, EventArgs e)
        {

        }
        // Clear Chip Button
        private void button1_Click(object sender, EventArgs e)
        {
            var x = newGame.GetBankAmmount();
            betInput.Text = x.ToString();
        }

        private void lbl_bet_ammount_Click(object sender, EventArgs e)
        {
           // newGame.GetStake().ToString();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            num = num + 100;
            betInput.Text = num.ToString();
        }

        private void lbl_player_score_Click(object sender, EventArgs e)
        {

        }

        private void pb_bank_Click(object sender, EventArgs e)
        {
            newGame.GetBankAmmount().ToString();
        }

        private void pb_chip_50_Click(object sender, EventArgs e)
        {
            num = num + 50;
            betInput.Text = num.ToString();
        }
        
        private void pb_chip_500_Click(object sender, EventArgs e)
        {
            num = num + 500;
            betInput.Text = num.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // betInput.Text = String.Empty;
            num = 0;
            betInput.Text = num.ToString();
        }

        private void lbl_wins_Click(object sender, EventArgs e)
        {

        }
    }
}
