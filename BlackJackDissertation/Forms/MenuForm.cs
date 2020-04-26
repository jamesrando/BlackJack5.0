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
            gameForm.updateUI();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
