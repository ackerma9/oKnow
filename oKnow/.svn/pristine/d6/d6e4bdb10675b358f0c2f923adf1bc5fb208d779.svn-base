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
    public class GameBoardTest
    {
		/// <summary>
        /// Test for the player name
        ///</summary>
        [TestMethod]
        public void PlayersTest1SmallStandard()
        {
            GameBoard board = new GameBoard(20, 5, 1, Category.VIDEOGAMES, BoardSize.SMALL, BoardType.STANDARD, null);
            Assert.AreEqual(1, board.Players.Count);
            Assert.AreEqual("Player1", board.Players[0].Name);
        }
		/// <summary>
        /// Test for the player name
        ///</summary>
        [TestMethod]
        public void PlayersTest2()
        {
            GameBoard board = new GameBoard(20, 5, 2, Category.VIDEOGAMES, BoardSize.SMALL, BoardType.STANDARD, null);
            Assert.AreEqual(2, board.Players.Count);
            Assert.AreEqual("Player1", board.Players[0].Name);
            Assert.AreEqual("Player2", board.Players[1].Name);
        }
		/// <summary>
        /// Test for the player name
        ///</summary>
        [TestMethod]
        public void PlayersTest1SmallRandom()
        {
            GameBoard board = new GameBoard(20, 5, 1, Category.VIDEOGAMES, BoardSize.SMALL, BoardType.RANDOM, new int[] { 10, 3, 3, 3, 2, 2 });
            Assert.AreEqual(1, board.Players.Count);
            Assert.AreEqual("Player1", board.Players[0].Name);
        }
		/// <summary>
        /// Test for the player name
        ///</summary>
        [TestMethod]
        public void PlayersTest1MediumRandom()
        {
            GameBoard board = new GameBoard(20, 5, 1, Category.VIDEOGAMES, BoardSize.MEDIUM, BoardType.RANDOM, new int[] { 10, 3, 3, 3, 2, 2 });
            Assert.AreEqual(1, board.Players.Count);
            Assert.AreEqual("Player1", board.Players[0].Name);
        }
		/// <summary>
        /// Test for the player name
        ///</summary>
        [TestMethod]
        public void PlayersTest1MediumStandard()
        {
            GameBoard board = new GameBoard(20, 5, 1, Category.VIDEOGAMES, BoardSize.MEDIUM, BoardType.STANDARD, null);
            Assert.AreEqual(1, board.Players.Count);
            Assert.AreEqual("Player1", board.Players[0].Name);
        }
		/// <summary>
        /// Test for the player name
        ///</summary>
        [TestMethod]
        public void PlayersTest1LargeStandard()
        {
            GameBoard board = new GameBoard(20, 5, 1, Category.VIDEOGAMES, BoardSize.LARGE, BoardType.STANDARD, null);
            Assert.AreEqual(1, board.Players.Count);
            Assert.AreEqual("Player1", board.Players[0].Name);
        }
		/// <summary>
        /// Test for the player name
        ///</summary>
        [TestMethod]
        public void PlayersTest1LargeRandom()
        {
            GameBoard board = new GameBoard(20, 5, 1, Category.VIDEOGAMES, BoardSize.LARGE, BoardType.RANDOM, new int[] { 10, 3, 3, 3, 2, 2 });
            Assert.AreEqual(1, board.Players.Count);
            Assert.AreEqual("Player1", board.Players[0].Name);
        }
    }
}
