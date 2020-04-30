using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackDissertation.Files
{
    public class LevelSystem
    {
        // fields

        public int _xp;
        public int _currentLevel;
        public int _xpnextlevel;
        private bool _playerWinner;

        public LevelSystem()
        {
            _currentLevel = 0;
            _xp = 0;
            _xpnextlevel = 100;
            _playerWinner = false;
        }

        public void AddXp(int ammount)
        {
            _xp += ammount;
            if (_xp >= _xpnextlevel)
            {
                // level up to next level
                _currentLevel++;
                _xp -= _xpnextlevel;
            }
        }

        public void PlayerWin()
        {
            if (_playerWinner == true)
            {
                AddXp(10);
            }

            PlayerLevelUp();
        }

        public void PlayerLevelUp()
        {
          

            if(_xp >= _xpnextlevel)
            {
                _currentLevel++;
            }
        }

       

        // get and setters
        public void SetXp(int xp)
        {
            this._xp = xp;
        }

        public int GetXp()
        {
            return _xp;
        }

        public void SetXpNextLevel(int xpnextlevel)
        {
            this._xpnextlevel = xpnextlevel;
        }

        public int GetXpNextLevel()
        {
            return _xpnextlevel;
        }

        public void SetPlayerWinner(bool playerwinner)
        {
            this._playerWinner = playerwinner;
        }

        public bool GetPlayerWinner()
        {
            return _playerWinner;
        }
        
        public void SetCurrentLevel(int currentlvl)
        {
            this._currentLevel = currentlvl;
        }

        public int GetCurrentLevel()
        {
            return _currentLevel;
        }


    }
}


