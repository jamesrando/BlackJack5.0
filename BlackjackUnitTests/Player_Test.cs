using System;
using BlackJackDissertation.Files;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BlackjackUnitTests
{
    [TestClass]
    public class Player_Test
    {
        [TestMethod]
        public void Add_Card_False()
        {
            // Assert
            var player = new Player();
            player.SetCardAmmountValue(4);
     
          
        }
    }
}
