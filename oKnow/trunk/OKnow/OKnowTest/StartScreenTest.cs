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
		/// <summary>
        /// Test for the number of players selected
        ///</summary>
        [TestMethod]
        public void TestGetCurrentNumPlayers1()
        {
            Assert.AreEqual(1, startScreen.getNumPlayers());
        }
		/// <summary>
        /// Test for changing the number of players selected
        ///</summary>
        [TestMethod]
        public void TestGetCurrentNumPlayers2()
        {
            startScreen.ChangeNumPlayers(1);
            Assert.AreEqual(2, startScreen.getNumPlayers());
        }
		/// <summary>
        /// Test for changing the number of players selected
        ///</summary>
        [TestMethod]
        public void TestGetCurrentNumPlayers3()
        {
            startScreen.ChangeNumPlayers(1);
            startScreen.ChangeNumPlayers(1);
            Assert.AreEqual(3, startScreen.getNumPlayers());
        }
		/// <summary>
        /// Test for changing the number of players selected
        ///</summary>
        [TestMethod]
        public void TestGetCurrentNumPlayers4()
        {
            startScreen.ChangeNumPlayers(1);
            startScreen.ChangeNumPlayers(1);
            startScreen.ChangeNumPlayers(1);
            Assert.AreEqual(4, startScreen.getNumPlayers());
        }
		/// <summary>
        /// Test for changing the number of players selected
        ///</summary>
        [TestMethod]
        public void TestGetCurrentNumPlayers5()
        {
            startScreen.ChangeNumPlayers(-1);
            Assert.AreEqual(4, startScreen.getNumPlayers());
        }
		/// <summary>
        /// Test for changing the number of players selected
        ///</summary>
        [TestMethod]
        public void TestGetCurrentNumPlayers6()
        {
            startScreen.ChangeNumPlayers(1);
            startScreen.ChangeNumPlayers(-1);
            startScreen.ChangeNumPlayers(1);
            startScreen.ChangeNumPlayers(1);
            Assert.AreEqual(3, startScreen.getNumPlayers());
        }
		/// <summary>
        /// Test for changing the number of players selected
        ///</summary>
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
		/// <summary>
        /// Test for changing the number of players selected
        ///</summary>
        private void TestNumPlayersHelper(int[] array, int answer)
        {
            foreach (int n in array)
            {
                startScreen.ChangeNumPlayers(n);
            }
            Assert.AreEqual(answer, startScreen.getNumPlayers());
        }
		/// <summary>
        /// Test for changing the category selected
        ///</summary>
        [TestMethod]
        public void TestGetCurrentCategory1()
        {
            Assert.AreEqual(Category.VIDEOGAMES, startScreen.GetCurrentCategory());
        }
		/// <summary>
        /// Test for changing the category selected
        ///</summary>
        [TestMethod]
        public void TestGetCurrentCategory2()
        {
            startScreen.ChangeCategory(1);
            Assert.AreEqual(Category.MOVIES, startScreen.GetCurrentCategory());
        }
		/// <summary>
        /// Test for changing the category selected
        ///</summary>
        [TestMethod]
        public void TestGetCurrentCategory3()
        {
            startScreen.ChangeCategory(1);
            startScreen.ChangeCategory(1);
            Assert.AreEqual(Category.MUSIC, startScreen.GetCurrentCategory());
        }
		/// <summary>
        /// Test for changing the category selected
        ///</summary>
        [TestMethod]
        public void TestGetCurrentCategory4()
        {
            startScreen.ChangeCategory(1);
            startScreen.ChangeCategory(1);
            startScreen.ChangeCategory(1);
            Assert.AreEqual(Category.TVSHOWS, startScreen.GetCurrentCategory());
        }
		/// <summary>
        /// Test for changing the category selected
        ///</summary>
        [TestMethod]
        public void TestGetCurrentCategory5()
        {
            startScreen.ChangeCategory(-1);
            Assert.AreEqual(Category.TVSHOWS, startScreen.GetCurrentCategory());
        }
		/// <summary>
        /// Test for changing the category selected
        ///</summary>
        [TestMethod]
        public void TestGetCurrentCategory6()
        {
            startScreen.ChangeCategory(1);
            startScreen.ChangeCategory(-1);
            startScreen.ChangeCategory(1);
            startScreen.ChangeCategory(1);
            Assert.AreEqual(Category.MUSIC, startScreen.GetCurrentCategory());
        }
		/// <summary>
        /// Test for changing the category selected
        ///</summary>
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
		/// <summary>
        /// Test for changing the category selected
        ///</summary>
        private void TestCategoryHelper(int[] array, Category answer)
        {
            foreach (int n in array)
            {
                startScreen.ChangeCategory(n);
            }
            Assert.AreEqual(answer, startScreen.GetCurrentCategory());
        }
		/// <summary>
        /// Test for generating left arrows
        ///</summary>
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
		/// <summary>
        /// Test for generating right arrows
        ///</summary>
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
		/// <summary>
        /// Test for generating left arrows
        ///</summary>
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
		/// <summary>
        /// Test for generating right arrows
        ///</summary>
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
