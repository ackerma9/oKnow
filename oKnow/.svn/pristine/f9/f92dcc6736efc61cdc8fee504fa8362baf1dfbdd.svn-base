using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OKnow;
using OKnow.Questions;
using Microsoft.Xna.Framework;

namespace OKnowTest
{
    [TestClass]
    public class StartScreenTest
    {
        StartScreen screen;

        /// <summary>
        ///Initialize() is called once during test execution before each
        ///test method in this test class are executed.
        ///</summary>
        [TestInitialize()]
        public void Initialize()
        {
            screen = new StartScreen();
        }

        [TestMethod]
        public void TestGetCurrentCategory()
        {
            Assert.AreEqual(Category.VIDEOGAMES, screen.getCurrentCategory());
        }

        [TestMethod]
        public void TestGetPlayerLeftArrow()
        {
            Rectangle rec = new Rectangle(0, 0, 1000, 500);
            Rectangle newRec = screen.GetPlayerLeftArrow(rec);
            Assert.AreEqual(0, newRec.X);
            Assert.AreEqual(0, newRec.Y);
            Assert.AreEqual(868, newRec.Width);
            Assert.AreEqual(500, newRec.Height);
        }

        [TestMethod]
        public void TestGetPlayerRightArrow()
        {
            Rectangle rec = new Rectangle(0, 0, 1000, 500);
            Rectangle newRec = screen.GetPlayerRightArrow(rec);
            Assert.AreEqual(132, newRec.X);
            Assert.AreEqual(0, newRec.Y);
            Assert.AreEqual(868, newRec.Width);
            Assert.AreEqual(500, newRec.Height);
        }

        [TestMethod]
        public void TestGetCategoryLeftArrow()
        {
            Rectangle rec = new Rectangle(0, 0, 1000, 500);
            Rectangle newRec = screen.GetCategoryLeftArrow(rec);
            Assert.AreEqual(0, newRec.X);
            Assert.AreEqual(0, newRec.Y);
            Assert.AreEqual(838, newRec.Width);
            Assert.AreEqual(500, newRec.Height);
        }

        [TestMethod]
        public void TestGetCategoryRightArrow()
        {
            Rectangle rec = new Rectangle(0, 0, 1000, 500);
            Rectangle newRec = screen.GetCategoryRightArrow(rec);
            Assert.AreEqual(162, newRec.X);
            Assert.AreEqual(0, newRec.Y);
            Assert.AreEqual(838, newRec.Width);
            Assert.AreEqual(500, newRec.Height);
        }
    }
}
