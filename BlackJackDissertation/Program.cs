using BlackJackDissertation.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackDissertation
{
    static class Program
    {
        public static MenuForm mainMenu;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainMenu = new MenuForm();
            Application.Run(mainMenu);
        }
    }
}


