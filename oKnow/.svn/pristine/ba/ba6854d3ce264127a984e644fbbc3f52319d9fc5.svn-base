using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OKnow;

namespace OKnowTest
{
    [TestClass]
    public class GameBoardTest
    {
        [TestMethod]
        public void PlayersTest1()
        {
            GameBoard board = new GameBoard(20, 5, 1);
            Assert.AreEqual(1, board.Players.Count);
            Assert.AreEqual("Player1", board.Players[0].Name);
        }

        [TestMethod]
        public void PlayersTest2()
        {
            GameBoard board = new GameBoard(20, 5, 2);
            Assert.AreEqual(2, board.Players.Count);
            Assert.AreEqual("Player1", board.Players[0].Name);
            Assert.AreEqual("Player2", board.Players[1].Name);
        }
    }
}
