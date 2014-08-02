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
        public void TestGetCurrentNumPlayers1()
        {
            Assert.AreEqual(1, screen.getNumPlayers());
        }

        [TestMethod]
        public void TestGetCurrentNumPlayers2()
        {
            screen.changeNumPlayers(1);
            Assert.AreEqual(2, screen.getNumPlayers());
        }

        [TestMethod]
        public void TestGetCurrentNumPlayers3()
        {
            screen.changeNumPlayers(1);
            screen.changeNumPlayers(1);
            Assert.AreEqual(3, screen.getNumPlayers());
        }

        [TestMethod]
        public void TestGetCurrentNumPlayers4()
        {
            screen.changeNumPlayers(1);
            screen.changeNumPlayers(1);
            screen.changeNumPlayers(1);
            Assert.AreEqual(4, screen.getNumPlayers());
        }

        [TestMethod]
        public void TestGetCurrentNumPlayers5()
        {
            screen.changeNumPlayers(-1);
            Assert.AreEqual(4, screen.getNumPlayers());
        }

        [TestMethod]
        public void TestGetCurrentNumPlayers6()
        {
            screen.changeNumPlayers(1);
            screen.changeNumPlayers(-1);
            screen.changeNumPlayers(1);
            screen.changeNumPlayers(1);
            Assert.AreEqual(3, screen.getNumPlayers());
        }

        [TestMethod]
        public void TestNumPlayersParameter()
        {
            List<int[]> arrays = ParameterValues.Singleton().NumPlayersArray;
            List<int> answers = ParameterValues.Singleton().NumPlayersAnswer;

            for (int i = 0; i < answers.Count; i++)
            {
                screen.Reset();
                TestNumPlayersHelper(arrays[i], answers[i]);
            }
        }

        private void TestNumPlayersHelper(int[] array, int answer)
        {
            foreach (int n in array)
            {
                screen.changeNumPlayers(n);
            }
            Assert.AreEqual(answer, screen.getNumPlayers());
        }

        [TestMethod]
        public void TestGetCurrentCategory1()
        {
            Assert.AreEqual(Category.VIDEOGAMES, screen.getCurrentCategory());
        }

        [TestMethod]
        public void TestGetCurrentCategory2()
        {
            screen.changeCategory(1);
            Assert.AreEqual(Category.MOVIES, screen.getCurrentCategory());
        }

        [TestMethod]
        public void TestGetCurrentCategory3()
        {
            screen.changeCategory(1);
            screen.changeCategory(1);
            Assert.AreEqual(Category.MUSIC, screen.getCurrentCategory());
        }

        [TestMethod]
        public void TestGetCurrentCategory4()
        {
            screen.changeCategory(1);
            screen.changeCategory(1);
            screen.changeCategory(1);
            Assert.AreEqual(Category.TVSHOWS, screen.getCurrentCategory());
        }

        [TestMethod]
        public void TestGetCurrentCategory5()
        {
            screen.changeCategory(-1);
            Assert.AreEqual(Category.TVSHOWS, screen.getCurrentCategory());
        }

        [TestMethod]
        public void TestGetCurrentCategory6()
        {
            screen.changeCategory(1);
            screen.changeCategory(-1);
            screen.changeCategory(1);
            screen.changeCategory(1);
            Assert.AreEqual(Category.MUSIC, screen.getCurrentCategory());
        }

        [TestMethod]
        public void TestCategoryParameter()
        {
            List<int[]> arrays = ParameterValues.Singleton().CategoryArray;
            List<Category> answers = ParameterValues.Singleton().CategoryAnswer;

            for (int i = 0; i < answers.Count; i++)
            {
                screen.Reset();
                TestCategoryHelper(arrays[i], answers[i]);
            }
        }

        private void TestCategoryHelper(int[] array, Category answer)
        {
            foreach (int n in array)
            {
                screen.changeCategory(n);
            }
            Assert.AreEqual(answer, screen.getCurrentCategory());
        }

        [TestMethod]
        public void TestGetBoardSize1()
        {
            Assert.AreEqual(BoardSize.SMALL, screen.getCurrentBoardSize());
        }

        [TestMethod]
        public void TestGetBoardSize2()
        {
            screen.changeBoardSize(1);
            Assert.AreEqual(BoardSize.MEDIUM, screen.getCurrentBoardSize());
        }

        [TestMethod]
        public void TestGetBoardSize3()
        {
            screen.changeBoardSize(1);
            screen.changeBoardSize(1);
            Assert.AreEqual(BoardSize.LARGE, screen.getCurrentBoardSize());
        }

        [TestMethod]
        public void TestGetBoardSize4()
        {
            screen.changeBoardSize(1);
            screen.changeBoardSize(1);
            screen.changeBoardSize(1);
            Assert.AreEqual(BoardSize.SMALL, screen.getCurrentBoardSize());
        }

        [TestMethod]
        public void TestGetBoardSize5()
        {
            screen.changeBoardSize(-1);
            Assert.AreEqual(BoardSize.LARGE, screen.getCurrentBoardSize());
        }

        [TestMethod]
        public void TestGetBoardSize6()
        {
            screen.changeBoardSize(-1);
            screen.changeBoardSize(1);
            screen.changeBoardSize(1);
            Assert.AreEqual(BoardSize.MEDIUM, screen.getCurrentBoardSize());
        }

        [TestMethod]
        public void TestBoardSizeParameter()
        {
            List<int[]> arrays = ParameterValues.Singleton().BoardSizeArray;
            List<BoardSize> answers = ParameterValues.Singleton().BoardSizeAnswer;

            for (int i = 0; i < answers.Count; i++)
            {
                screen.Reset();
                TestBoardSizeHelper(arrays[i], answers[i]);
            }
        }

        private void TestBoardSizeHelper(int[] array, BoardSize answer)
        {
            foreach (int n in array)
            {
                screen.changeBoardSize(n);
            }
            Assert.AreEqual(answer, screen.getCurrentBoardSize());
        }

        [TestMethod]
        public void TestGetBoardType1()
        {
            Assert.AreEqual(BoardType.STANDARD, screen.getCurrentBoardType());
        }

        [TestMethod]
        public void TestGetBoardType2()
        {
            screen.changeBoardType(1);
            Assert.AreEqual(BoardType.RANDOM, screen.getCurrentBoardType());
        }

        [TestMethod]
        public void TestGetBoardType3()
        {
            screen.changeBoardType(-1);
            Assert.AreEqual(BoardType.RANDOM, screen.getCurrentBoardType());
        }

        [TestMethod]
        public void TestBoardTypeParameter()
        {
            List<int[]> arrays = ParameterValues.Singleton().BoardTypeArray;
            List<BoardType> answers = ParameterValues.Singleton().BoardTypeAnswer;

            for (int i = 0; i < answers.Count; i++)
            {
                screen.Reset();
                TestBoardTypeHelper(arrays[i], answers[i]);
            }
        }

        private void TestBoardTypeHelper(int[] array, BoardType answer)
        {
            foreach (int n in array)
            {
                screen.changeBoardType(n);
            }
            Assert.AreEqual(answer, screen.getCurrentBoardType());
        }

        [TestMethod]
        public void TestGetLeftArrow()
        {
            Rectangle rec = new Rectangle(0, 0, 1000, 500);
            Rectangle newRec = screen.GetLeftArrow(rec);
            Assert.AreEqual(0, newRec.X);
            Assert.AreEqual(0, newRec.Y);
            Assert.AreEqual(838, newRec.Width);
            Assert.AreEqual(500, newRec.Height);
        }

        [TestMethod]
        public void TestGetRightArrow()
        {
            Rectangle rec = new Rectangle(0, 0, 1000, 500);
            Rectangle newRec = screen.GetRightArrow(rec);
            Assert.AreEqual(162, newRec.X);
            Assert.AreEqual(0, newRec.Y);
            Assert.AreEqual(838, newRec.Width);
            Assert.AreEqual(500, newRec.Height);
        }
    }
}
