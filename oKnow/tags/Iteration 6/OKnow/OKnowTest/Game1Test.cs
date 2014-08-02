using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OKnow;
using OKnow.Questions;

namespace OKnowTest
{
    [TestClass]
    public class Game1Test
    {
        [TestMethod]
        public void StartGameTest1()
        {
            Game1 game = new Game1();
            game.StartGame(1, Category.VIDEOGAMES, BoardSize.SMALL, BoardType.STANDARD, null);
            Assert.AreEqual(1, game.NumPlayers);
        }

        [TestMethod]
        public void StartGameTest2()
        {
            Game1 game = new Game1();
            game.StartGame(2, Category.VIDEOGAMES, BoardSize.SMALL, BoardType.STANDARD, null);
            Assert.AreEqual(2, game.NumPlayers);
        }
    }
}
