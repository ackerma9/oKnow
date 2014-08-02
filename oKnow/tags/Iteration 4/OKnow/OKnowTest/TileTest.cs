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
using OKnow.Pieces;

namespace OKnowTest
{
    [TestClass]
    public class TileTest
    {
        private AbstractTile tile1;
        private AbstractTile tile2;
        private AbstractTile tile3;
        /// <summary>
        ///Initialize() is called once during test execution before
        ///test methods in this test class are executed.
        ///</summary>
        [TestInitialize()]
        public void Initialize()
        {
            Question q = new Question(Category.NONE, "What Color is the sky?", new string[] { "Green", "Red", "Blue", "Yellow" }, Answer.THREE, QuestionType.STANDARD);

            tile1 = new StandardTile(null, 10, 10);
            tile2 = new StandardTile(null, 11, 10);
            tile3 = new StandardTile(null, 11, 11);
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

        [TestMethod()]
        public void TestStandardTile()
        {
            StandardTile tile = new StandardTile(null, 0, 0);
            Assert.AreEqual(typeof(StandardTile), tile.GetType());
        }

        [TestMethod()]
        public void TestMusicTile()
        {
            MusicTile tile = new MusicTile(null, 0, 0);
            Assert.AreEqual(typeof(MusicTile), tile.GetType());
        }

        [TestMethod()]
        public void TestImageTile()
        {
            ImageTile tile = new ImageTile(null, 0, 0);
            Assert.AreEqual(typeof(ImageTile), tile.GetType());
        }

        [TestMethod()]
        public void TestDeathTile()
        {
            DeathTile tile = new DeathTile(null, 0, 0);
            Assert.AreEqual(typeof(DeathTile), tile.GetType());
        }

        [TestMethod()]
        public void TestJokerTile()
        {
            JokerTile tile = new JokerTile(null, 0, 0);
            Assert.AreEqual(typeof(JokerTile), tile.GetType());
        }
    }
}
