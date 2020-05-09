using BlackJackDissertation.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackDissertation.Files
{
    class Blackjack
    {
        // fields 

        private Deck _deck; // instance of the deck object
        private Player _player; // instance of the player object
        private Player _dealer; // instance of the dealer object
        private int _bank; // players money total
        private int _bet; // Players bet ammount that will be wagered 
        private double _payout;
        private bool _gameStatus;
        private int _gameWins;
        private int _gamesPlayed;
        private int _gamesLost;
        private int _returns; // ammount player returns at end of each hand

        // constructor

        public Blackjack()
        {
            _deck = new Deck();
            _player = new Player();
            _dealer = new Player();
            _bank = 1000; // player will begin with 1000 by default
            _bet = 0;
            _payout = 0;
            _gameStatus = false;
            _gameWins = 0;
            _gamesPlayed = 0;
            _gamesLost = 0;
        }

        // methods and get and setters

        /// <summary>
        /// will count the ammount of games are played during the application
        /// </summary>
        /// <returns></returns>
        public int GamesCount()
        {
            if(_gameStatus == true)
            {
                _gamesPlayed++;
            }
            return _gamesPlayed;
        }

        /// <summary>
        /// determines if the bet that is being placed is enough to wager with there current cash ammount
        /// </summary>
        /// <param name="bet"></param>
        public bool Bet(int bet)
        {
            if (bet <= 0) // if bet is less than zero than player can not play
            {
                MessageBox.Show("your bet ammount is not enough to wager", "please choose a higher ammount");
                return false;
            }
            else if (bet > _bank) // if bet is greater than current cash ammount than player can not play
            {
                MessageBox.Show("you currently dont have enough chips to be able to make this bet", "please enter a lower ammount to play");
                return false;
            }
            else 
            {
                _bet = bet;
                _bank -= _bet;
                return true;
            }
        }

      
        /// <summary>
        /// provides the player and dealer with 2 cards which is the beginning of the hand
        /// </summary>
        public void Deal()
        {
            _player.AddCard(_deck.DrawCard());
            _player.AddCard(_deck.DrawCard());
            _dealer.AddCard(_deck.DrawCard());
            _dealer.AddCard(_deck.DrawCard());

            if (_player.GetPlayerTotal() == 21)
            {
                MenuForm.gameForm.DisplayHand("user");
                HandOutcome();
            }
        }

        /// <summary>
        /// new hand will create player and dealer and provide two cards
        /// </summary>
        public void NewHand()
        {
            _player = new Player();
            _dealer = new Player();
            MenuForm.gameForm.hitBtn.Tag = "BetPhase"; // updates game to bet phase
            MenuForm.gameForm.UpdateUI(); // updates ui 
        
        }

        public void DealerHand()
        {
            
            MenuForm.gameForm.dealerCard1.Image = _dealer.GetCard()[0].GetCardFace(); // exception thrown
            MenuForm.gameForm.lbl_dealer_score.Text = "Dealers Score\n" + _dealer.GetPlayerTotal();
            MenuForm.gameForm.dealerCard1.Update();
            MenuForm.gameForm.lbl_dealer_score.Update();

            // dealer must reach a score of minimuim of 17 otherwise will draw another card from the deck
            while (_dealer.GetPlayerTotal() < 17)
            {
                _dealer.AddCard(_deck.DrawCard());
                //If score goes over 21, checks to see if there is an ace than can be counted as 1 score (instead of 11)
                if (_dealer.GetPlayerTotal() > 21)
                {
                    for (int index = 0; index < _dealer.GetCardAmmount(); index++)
                    {
                        if (_dealer.GetCard()[index].GetRank() == "A" && _dealer.GetCard()[index].GetValue() == 11) //
                        {
                            _dealer.GetCard()[index].SetValue(1);
                            break;
                        }
                    }
                }
                System.Threading.Thread.Sleep(1000);
                MenuForm.gameForm.DisplayHand("dealer");
                _dealer.UpdateHand();
                MenuForm.gameForm.lbl_dealer_score.Text = "Dealer Score\n" + _dealer.GetPlayerTotal();
                MenuForm.gameForm.lbl_dealer_score.Update();
                
            }
            HandOutcome();        
        }
        public void PlayerWins()
        {
            if (_player.GetCardAmmount() == 2 && _player.GetPlayerTotal() == 21)
            {

                MessageBox.Show("Player has BlackJack!");
                _payout = 2.5;
                _gameWins++;
            }
            else if (_player.GetCardAmmount() == 5 && _player.GetPlayerTotal() < 21)
            {
                MessageBox.Show("Player has reached under 21 with five cards", "Player Wins!");
                _payout = 2;
                _gameWins++;
            }
            else if ((_player.GetPlayerTotal() <= 21) && (_player.GetPlayerTotal() > _dealer.GetPlayerTotal()) && (_player.GetPlayerTotal() <= 21))
            {
                MessageBox.Show("Player has a higher score than Dealer", "Player Wins a payout of {0}" + _payout); // test
                _payout = 2;
                _gameWins++;
            }
            else if ((_player.GetPlayerTotal() <= 21) && (_dealer.GetPlayerTotal() > 21))
            {
                MessageBox.Show("Dealer has gone BUST", "Player Wins!");
                _payout = 2;
                _gameWins++;
            }
            else if ((_player.GetPlayerTotal() <= 21) && (_player.GetPlayerTotal() == _dealer.GetPlayerTotal()))
            {
                MessageBox.Show("Player and Dealer both have the same Score!", "PUSH!");
                _payout = 1;
            }

        }

        /// <summary>
        /// determines the winner of the hand between the player and dealer
        /// </summary>
        public void HandOutcome()
        {
            // if the player gets a blackjack
            if (_player.GetCardAmmount() == 2 && _player.GetPlayerTotal() == 21)
            {

                MessageBox.Show("Player has BlackJack!");
                _payout = 2.5;
                _gameWins++;
            }
            // if the player gets five cards and doesnt bust
            else if (_player.GetCardAmmount() == 5 && _player.GetPlayerTotal() < 21)
            {
                MessageBox.Show("Player has reached under 21 with five cards", "Player Wins!");
                _payout = 2;
                _gameWins++;
            }
            // if player and dealer dont bust but the player has a higher score than the dealer
            else if ((_player.GetPlayerTotal() <= 21) && (_player.GetPlayerTotal() > _dealer.GetPlayerTotal()) && (_player.GetPlayerTotal() <= 21))
            {
                MessageBox.Show("Player has a higher score than Dealer", "Player Wins a payout of {0}" + _returns); // test
                _payout = 2;
                _gameWins++;
            }
            // if player and dealer dont bust but dealer has a higher score the player
            else if ((_player.GetPlayerTotal() <= 21) && (_player.GetPlayerTotal() < _dealer.GetPlayerTotal()) && (_dealer.GetPlayerTotal() <= 21))
            {
                MessageBox.Show("Dealer has a higher score than Player", "Dealer Wins!");
                _payout = 0;
                _gamesLost++;
            }
            // if the dealer goes bust
            else if ((_player.GetPlayerTotal() <= 21) && (_dealer.GetPlayerTotal() > 21))
            {
                MessageBox.Show("Dealer has gone BUST", "Player Wins!");
                _payout = 2;
                _gameWins++;
            }
            // if player goes bust
            else if ((_player.GetPlayerTotal() > 21) )
            {
                MessageBox.Show("Player has scored over 21", "Dealer Wins!");
                _payout = 0;
                _gamesLost++;
            }
            // if player and dealer have the same score
            else if ((_player.GetPlayerTotal() <= 21) && (_player.GetPlayerTotal() == _dealer.GetPlayerTotal()))
            {
                MessageBox.Show("Player and Dealer both have the same Score!", "PUSH!");
                _payout = 1;
            }
            // calculates hand result and updates the game based on the winner
            _bank += (int)(_bet * _payout);
            MenuForm.gameForm.hitBtn.Tag = "BetPhase";

           // if player still has cash they can play a new hand otherwise game over
           if (_bank > 0)
           {
                NewHand();
           }
            else
            {
                GameEnd();
            }

            // payout test

            

        }
        
       
        /// <summary>
        /// This will close the application / current game and all values will be reset to there default
        /// </summary>
        public void GameEnd()
        {
            MessageBox.Show("Thank you for playing Blackjack", "Your Score was\n" + _bank);

            // resets game to defaults and restarts to play a fresh game
            _gameStatus = false;
            _deck.ShuffleDeck();
            _bank = 1000;
            NewHand();
            MenuForm.gameForm.Hide();
            MenuForm.gameForm.btn_stand.Visible = false;
        }

        #region Getters and Setters

        public void SetDeck(Deck deck)
        {
            this._deck = deck;
        }

        public Deck GetDeck()
        {
            return this._deck;
        }

        public void SetPlayer(Player player)
        {
            this._player = player;
        }

        public Player GetPlayer()
        {
            return this._player;
        }

        public void SetDealer(Player dealer)
        {
            this._dealer = dealer;
        }

        public Player GetDealer()
        {
            return this._dealer;
        }

        public void SetBankAmmount(int bank)
        {
            this._bank = bank;
        }

        public int GetBankAmmount()
        {
            return this._bank;
        }

        public void SetStake(int stake)
        {
            this._bet = stake;
        }

        public int GetStake()
        {
            return this._bet;
        }

        public void SetPayout(double payout)
        {
            this._payout = payout;
        }

        public double GetPayout()
        {
            return this._payout;
        }

        public void SetGameStatus(bool status)
        {
            this._gameStatus = status;
        }

        public bool GetGameStatus()
        {
            return this._gameStatus;
        }

        public void SetGameWin(int gamewin)
        {
            this._gameWins = gamewin;
        }

        public int GetGameWin()
        {
            return this._gameWins;
        }

        public void SetGameLoss(int gameloss)
        {
            this._gamesLost = gameloss;
        }

        public int GetGameLoss()
        {
            return this._gamesLost;
        }

        public void SetReturns(int returns)
        {
            this._returns = returns;
            _returns = (int)(_bet * _payout);
        }
        public int GetReturns()
        {
            return _returns;
        }

        #endregion

    }
}
