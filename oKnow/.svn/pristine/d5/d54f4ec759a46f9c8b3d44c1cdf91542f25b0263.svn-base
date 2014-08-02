using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OKnow;
using OKnow.UI;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using OKnow.Questions;

namespace OKnowTest
{
    [TestClass]
    public class TileTest
    {
        private Tile tile1;
        private Tile tile2;
        private Tile tile3;
        /// <summary>
        ///Initialize() is called once during test execution before
        ///test methods in this test class are executed.
        ///</summary>
        [TestInitialize()]
        public void Initialize()
        {
            TileType tileType = TileType.STANDARD;
            Question q = new Question(Category.NONE, "What Color is the sky?", new string[] { "Green", "Red", "Blue", "Yellow" }, Answer.THREE);

            tile1 = new Tile(null, tileType, 10, 10);
            tile2 = new Tile(null, tileType, 11, 10);
            tile3 = new Tile(null, tileType, 11, 11);
        }

        /// <summary>
        ///A test for Tile Constructor
        ///</summary>
        [TestMethod()]
        public void TileConstructorTest()
        {
            Assert.IsNotNull(tile1);
        }

        /// <summary>
        ///A test for getting and setting the boardX variable
        ///</summary>
        [TestMethod()]
        public void GetSetTileTypeTest()
        {
            Assert.AreEqual(TileType.STANDARD, tile1.TileType);
            tile1.TileType = TileType.DEATH;
            Assert.AreEqual(TileType.DEATH, tile1.TileType);
        }

        /// <summary>
        ///A test for getting and setting the boardX variable
        ///</summary>
        [TestMethod()]
        public void GetSetBoardXTest()
        {
            Assert.AreEqual(10, tile1.BoardX);
            tile1.BoardX = 20;
            Assert.AreEqual(20, tile1.BoardX);
        }

        /// <summary>
        ///A test for getting and setting the boardY variable
        ///</summary>
        [TestMethod()]
        public void GetSetBoardYTest()
        {
            Assert.AreEqual(10, tile1.BoardY);
            tile1.BoardY = 20;
            Assert.AreEqual(20, tile1.BoardY);
        }

        /// <summary>
        ///A test for getting and setting the boardY variable
        ///</summary>
        [TestMethod()]
        public void IsAdjacentTest()
        {
            Assert.IsTrue(tile1.IsAdjacent(tile2));
            Assert.IsFalse(tile1.IsAdjacent(tile3));
        }
    }
}
