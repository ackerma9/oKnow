using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OKnow;

namespace OKnowTest
{
    [TestClass]
    public class PlayerTest
    {
        private Player player;
        private Tile tile1;
        private Tile tile2;


        /// <summary>
        ///Initialize() is called once during test execution before
        ///test methods in this test class are executed.
        ///</summary>
        [TestInitialize()]
        public void Initialize()
        {
            TileType tileType = TileType.STANDARD;
            int boardX = 10;
            int boardY = 10;
            tile1 = new Tile(null, tileType, boardX, boardY);
            tile2 = new Tile(null, TileType.DEATH, boardX, boardY);
            player = new Player(tile1);
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
    }
}
