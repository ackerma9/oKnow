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
        StartScreen startScreen;

        /// <summary>
        ///Initialize() is called once during test execution before each
        ///test method in this test class are executed.
        ///</summary>
        [TestInitialize()]
        public void Initialize()
        {
            startScreen = new StartScreen();
        }

        [TestMethod]
        public void TestGetCurrentNumPlayers1()
        {
            Assert.AreEqual(1, startScreen.getNumPlayers());
        }

        [TestMethod]
        public void TestGetCurrentNumPlayers2()
        {
            startScreen.changeNumPlayers(1);
            Assert.AreEqual(2, startScreen.getNumPlayers());
        }

        [TestMethod]
        public void TestGetCurrentNumPlayers3()
        {
            startScreen.changeNumPlayers(1);
            startScreen.changeNumPlayers(1);
            Assert.AreEqual(3, startScreen.getNumPlayers());
        }

        [TestMethod]
        public void TestGetCurrentNumPlayers4()
        {
            startScreen.changeNumPlayers(1);
            startScreen.changeNumPlayers(1);
            startScreen.changeNumPlayers(1);
            Assert.AreEqual(4, startScreen.getNumPlayers());
        }

        [TestMethod]
        public void TestGetCurrentNumPlayers5()
        {
            startScreen.changeNumPlayers(-1);
            Assert.AreEqual(4, startScreen.getNumPlayers());
        }

        [TestMethod]
        public void TestGetCurrentNumPlayers6()
        {
            startScreen.changeNumPlayers(1);
            startScreen.changeNumPlayers(-1);
            startScreen.changeNumPlayers(1);
            startScreen.changeNumPlayers(1);
            Assert.AreEqual(3, startScreen.getNumPlayers());
        }

        [TestMethod]
        public void TestNumPlayersParameter()
        {
            List<int[]> arrays = ParameterValues.Singleton().NumPlayersArray;
            List<int> answers = ParameterValues.Singleton().NumPlayersAnswer;

            for (int i = 0; i < answers.Count; i++)
            {
                startScreen.Reset();
                TestNumPlayersHelper(arrays[i], answers[i]);
            }
        }

        private void TestNumPlayersHelper(int[] array, int answer)
        {
            foreach (int n in array)
            {
                startScreen.changeNumPlayers(n);
            }
            Assert.AreEqual(answer, startScreen.getNumPlayers());
        }

        [TestMethod]
        public void TestGetCurrentCategory1()
        {
            Assert.AreEqual(Category.VIDEOGAMES, startScreen.getCurrentCategory());
        }

        [TestMethod]
        public void TestGetCurrentCategory2()
        {
            startScreen.changeCategory(1);
            Assert.AreEqual(Category.MOVIES, startScreen.getCurrentCategory());
        }

        [TestMethod]
        public void TestGetCurrentCategory3()
        {
            startScreen.changeCategory(1);
            startScreen.changeCategory(1);
            Assert.AreEqual(Category.MUSIC, startScreen.getCurrentCategory());
        }

        [TestMethod]
        public void TestGetCurrentCategory4()
        {
            startScreen.changeCategory(1);
            startScreen.changeCategory(1);
            startScreen.changeCategory(1);
            Assert.AreEqual(Category.TVSHOWS, startScreen.getCurrentCategory());
        }

        [TestMethod]
        public void TestGetCurrentCategory5()
        {
            startScreen.changeCategory(-1);
            Assert.AreEqual(Category.TVSHOWS, startScreen.getCurrentCategory());
        }

        [TestMethod]
        public void TestGetCurrentCategory6()
        {
            startScreen.changeCategory(1);
            startScreen.changeCategory(-1);
            startScreen.changeCategory(1);
            startScreen.changeCategory(1);
            Assert.AreEqual(Category.MUSIC, startScreen.getCurrentCategory());
        }

        [TestMethod]
        public void TestCategoryParameter()
        {
            List<int[]> arrays = ParameterValues.Singleton().CategoryArray;
            List<Category> answers = ParameterValues.Singleton().CategoryAnswer;

            for (int i = 0; i < answers.Count; i++)
            {
                startScreen.Reset();
                TestCategoryHelper(arrays[i], answers[i]);
            }
        }

        private void TestCategoryHelper(int[] array, Category answer)
        {
            foreach (int n in array)
            {
                startScreen.changeCategory(n);
            }
            Assert.AreEqual(answer, startScreen.getCurrentCategory());
        }

        [TestMethod]
        public void TestGetLeftArrow()
        {
            Rectangle rec = new Rectangle(0, 0, 1000, 500);
            Rectangle newRec = startScreen.GetLeftArrow(rec);
            Assert.AreEqual(0, newRec.X);
            Assert.AreEqual(0, newRec.Y);
            Assert.AreEqual(838, newRec.Width);
            Assert.AreEqual(500, newRec.Height);
        }

        [TestMethod]
        public void TestGetRightArrow()
        {
            Rectangle rec = new Rectangle(0, 0, 1000, 500);
            Rectangle newRec = startScreen.GetRightArrow(rec);
            Assert.AreEqual(162, newRec.X);
            Assert.AreEqual(0, newRec.Y);
            Assert.AreEqual(838, newRec.Width);
            Assert.AreEqual(500, newRec.Height);
        }

        [TestMethod]
        public void TestLeftArrowParameter()
        {
            List<Rectangle> parameters = ParameterValues.Singleton().LeftArrowParam;
            List<Rectangle> answers = ParameterValues.Singleton().LeftArrowAnswer;

            for (int i = 0; i < answers.Count; i++)
            {
                Assert.AreEqual(answers[i], startScreen.GetLeftArrow(parameters[i]));
            }
        }

        [TestMethod]
        public void TestRightArrowParameter()
        {
            List<Rectangle> parameters = ParameterValues.Singleton().RightArrowParam;
            List<Rectangle> answers = ParameterValues.Singleton().RightArrowAnswer;

            for (int i = 0; i < answers.Count; i++)
            {
                Assert.AreEqual(answers[i], startScreen.GetRightArrow(parameters[i]));
            }
        }
    }
}
