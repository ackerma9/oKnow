using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OKnow;
using OKnow.Questions;
using OKnow.Pieces;
namespace OKnowTest
{
    [TestClass]
    public class PlayerTest
    {
        private Player player;
        private AbstractTile tile1;
        private AbstractTile tile2;


        /// <summary>
        ///Initialize() is called once during test execution before each
        ///test method in this test class are executed.
        ///</summary>
        [TestInitialize()]
        public void Initialize()
        {
            Player.Reset();
            int boardX = 10;
            int boardY = 10;
            tile1 = new StandardTile(null, boardX, boardY);
            tile2 = new DeathTile(null, boardX, boardY);
            player = new Player("Player1", tile1);
        }

        /// <summary>
        ///A test for Tile Constructor
        ///</summary>
        [TestMethod()]
        public void TileConstructorTest()
        {
            Assert.IsNotNull(player);
        }

        /// <summary>
        ///A test for getting and setting the boardX variable
        ///</summary>
        [TestMethod()]
        public void GetSetPlayerTileTest()
        {
            Assert.AreEqual(tile1, player.getTile());
            player.setTile(tile2);
            Assert.AreEqual(tile2, player.getTile());
        }

        /// <summary>
        ///A test for getting and setting the name variable
        ///</summary>
        [TestMethod()]
        public void GetSetPlayerNameTest()
        {
            Assert.AreEqual("Player1", player.Name);
            player.Name = "Player2";
            Assert.AreEqual("Player2", player.Name);
        }

        /// <summary>
        ///A test for constructing multiple players
        ///</summary>
        [TestMethod()]
        public void MultiplePlayerTest()
        {
            Player.Reset();
            for (int i = 0; i < Player.MaxPlayers; i++)
            {
                try
                {
                    new Player(tile1);
                }
                catch (Exception e)
                {
                    Assert.Fail(e.Message + "\n" + "Player failed to construct " + i.ToString());
                }
            }

            try
            {
                new Player(tile1);
                Assert.Fail("Player did not fail to construct");
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }

        }

        /// <summary>
        ///A test for winning conditions
        ///</summary>
        [TestMethod()]
        public void VictoryTest()
        {
            Player.Reset();
            GameBoard gameBoard = new GameBoard(20, 5, 4, Category.VIDEOGAMES, BoardSize.SMALL, BoardType.STANDARD, null);
            Player player = gameBoard.CurrentPlayer;
            player.setTile(gameBoard.EndTile);
            Assert.AreEqual(gameBoard.Winner, player);
        }
    }
}
