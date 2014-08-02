using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OKnow;

namespace OKnowTest
{
    [TestClass]
    public class Game1Test
    {
        [TestMethod]
        public void StartGameTest1()
        {
            Game1 game = new Game1();
            game.StartGame(1);
            Assert.AreEqual(1, game.NumPlayers);
        }

        [TestMethod]
        public void StartGameTest2()
        {
            Game1 game = new Game1();
            game.StartGame(2);
            Assert.AreEqual(2, game.NumPlayers);
        }
    }
}
