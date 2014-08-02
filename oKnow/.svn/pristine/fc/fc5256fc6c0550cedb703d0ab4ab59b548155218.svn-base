using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OKnow;

namespace OKnowTest
{
    [TestClass]
    public class OptionScreenTest
    {
        OptionsScreen optionsScreen;

        /// <summary>
        ///Initialize() is called once during test execution before each
        ///test method in this test class are executed.
        ///</summary>
        [TestInitialize()]
        public void Initialize()
        {
            optionsScreen = new OptionsScreen();
        }

        [TestMethod]
        public void TestGetBoardSize1()
        {
            Assert.AreEqual(BoardSize.SMALL, optionsScreen.getCurrentBoardSize());
        }

        [TestMethod]
        public void TestGetBoardSize2()
        {
            optionsScreen.changeBoardSize(1);
            Assert.AreEqual(BoardSize.MEDIUM, optionsScreen.getCurrentBoardSize());
        }

        [TestMethod]
        public void TestGetBoardSize3()
        {
            optionsScreen.changeBoardSize(1);
            optionsScreen.changeBoardSize(1);
            Assert.AreEqual(BoardSize.LARGE, optionsScreen.getCurrentBoardSize());
        }

        [TestMethod]
        public void TestGetBoardSize4()
        {
            optionsScreen.changeBoardSize(1);
            optionsScreen.changeBoardSize(1);
            optionsScreen.changeBoardSize(1);
            Assert.AreEqual(BoardSize.SMALL, optionsScreen.getCurrentBoardSize());
        }

        [TestMethod]
        public void TestGetBoardSize5()
        {
            optionsScreen.changeBoardSize(-1);
            Assert.AreEqual(BoardSize.LARGE, optionsScreen.getCurrentBoardSize());
        }

        [TestMethod]
        public void TestGetBoardSize6()
        {
            optionsScreen.changeBoardSize(-1);
            optionsScreen.changeBoardSize(1);
            optionsScreen.changeBoardSize(1);
            Assert.AreEqual(BoardSize.MEDIUM, optionsScreen.getCurrentBoardSize());
        }

        [TestMethod]
        public void TestBoardSizeParameter()
        {
            List<int[]> arrays = ParameterValues.Singleton().BoardSizeArray;
            List<BoardSize> answers = ParameterValues.Singleton().BoardSizeAnswer;

            for (int i = 0; i < answers.Count; i++)
            {
                optionsScreen.Reset();
                TestBoardSizeHelper(arrays[i], answers[i]);
            }
        }

        private void TestBoardSizeHelper(int[] array, BoardSize answer)
        {
            foreach (int n in array)
            {
                optionsScreen.changeBoardSize(n);
            }
            Assert.AreEqual(answer, optionsScreen.getCurrentBoardSize());
        }

        [TestMethod]
        public void TestGetBoardType1()
        {
            Assert.AreEqual(BoardType.STANDARD, optionsScreen.getCurrentBoardType());
        }

        [TestMethod]
        public void TestGetBoardType2()
        {
            optionsScreen.changeBoardType(1);
            Assert.AreEqual(BoardType.RANDOM, optionsScreen.getCurrentBoardType());
        }

        [TestMethod]
        public void TestGetBoardType3()
        {
            optionsScreen.changeBoardType(-1);
            Assert.AreEqual(BoardType.RANDOM, optionsScreen.getCurrentBoardType());
        }

        [TestMethod]
        public void TestBoardTypeParameter()
        {
            List<int[]> arrays = ParameterValues.Singleton().BoardTypeArray;
            List<BoardType> answers = ParameterValues.Singleton().BoardTypeAnswer;

            for (int i = 0; i < answers.Count; i++)
            {
                optionsScreen.Reset();
                TestBoardTypeHelper(arrays[i], answers[i]);
            }
        }

        private void TestBoardTypeHelper(int[] array, BoardType answer)
        {
            foreach (int n in array)
            {
                optionsScreen.changeBoardType(n);
            }
            Assert.AreEqual(answer, optionsScreen.getCurrentBoardType());
        }

        [TestMethod]
        public void TestGetTileWeights1()
        {
            Assert.AreEqual(10, optionsScreen.getTileWeights()[0]);
            Assert.AreEqual(3, optionsScreen.getTileWeights()[1]);
            Assert.AreEqual(3, optionsScreen.getTileWeights()[2]);
            Assert.AreEqual(3, optionsScreen.getTileWeights()[3]);
            Assert.AreEqual(2, optionsScreen.getTileWeights()[4]);
            Assert.AreEqual(2, optionsScreen.getTileWeights()[5]);
        }

        [TestMethod]
        public void TestGetTileWeights2()
        {
            optionsScreen.changeTileWeight(1, 1);
            Assert.AreEqual(10, optionsScreen.getTileWeights()[0]);
            Assert.AreEqual(4, optionsScreen.getTileWeights()[1]);
            Assert.AreEqual(3, optionsScreen.getTileWeights()[2]);
            Assert.AreEqual(3, optionsScreen.getTileWeights()[3]);
            Assert.AreEqual(2, optionsScreen.getTileWeights()[4]);
            Assert.AreEqual(2, optionsScreen.getTileWeights()[5]);
        }

        [TestMethod]
        public void TestGetTileWeights3()
        {
            optionsScreen.changeTileWeight(1, 1);
            optionsScreen.changeTileWeight(1, 1);
            optionsScreen.changeTileWeight(1, 1);
            Assert.AreEqual(10, optionsScreen.getTileWeights()[0]);
            Assert.AreEqual(5, optionsScreen.getTileWeights()[1]);
            Assert.AreEqual(3, optionsScreen.getTileWeights()[2]);
            Assert.AreEqual(3, optionsScreen.getTileWeights()[3]);
            Assert.AreEqual(2, optionsScreen.getTileWeights()[4]);
            Assert.AreEqual(2, optionsScreen.getTileWeights()[5]);
        }

        [TestMethod]
        public void TestGetTileWeights4()
        {
            optionsScreen.changeTileWeight(1, 1);
            optionsScreen.changeTileWeight(1, 1);
            optionsScreen.changeTileWeight(2, -1);
            optionsScreen.changeTileWeight(2, -1);
            Assert.AreEqual(10, optionsScreen.getTileWeights()[0]);
            Assert.AreEqual(5, optionsScreen.getTileWeights()[1]);
            Assert.AreEqual(1, optionsScreen.getTileWeights()[2]);
            Assert.AreEqual(3, optionsScreen.getTileWeights()[3]);
            Assert.AreEqual(2, optionsScreen.getTileWeights()[4]);
            Assert.AreEqual(2, optionsScreen.getTileWeights()[5]);
        }

        [TestMethod]
        public void TestGetTileWeights5()
        {
            optionsScreen.changeTileWeight(0, -1);
            optionsScreen.changeTileWeight(0, -1);
            optionsScreen.changeTileWeight(0, -1);
            optionsScreen.changeTileWeight(0, -1);
            optionsScreen.changeTileWeight(0, -1);
            optionsScreen.changeTileWeight(0, -1);
            optionsScreen.changeTileWeight(0, -1);
            optionsScreen.changeTileWeight(0, -1);
            optionsScreen.changeTileWeight(2, -1);
            optionsScreen.changeTileWeight(2, -1);
            Assert.AreEqual(2, optionsScreen.getTileWeights()[0]);
            Assert.AreEqual(3, optionsScreen.getTileWeights()[1]);
            Assert.AreEqual(1, optionsScreen.getTileWeights()[2]);
            Assert.AreEqual(3, optionsScreen.getTileWeights()[3]);
            Assert.AreEqual(2, optionsScreen.getTileWeights()[4]);
            Assert.AreEqual(2, optionsScreen.getTileWeights()[5]);
        }

        [TestMethod]
        public void TestGetTileWeights6()
        {
            optionsScreen.changeTileWeight(1, 1);
            optionsScreen.changeTileWeight(1, 1);
            optionsScreen.changeTileWeight(2, -1);
            optionsScreen.changeTileWeight(2, -1);
            optionsScreen.changeTileWeight(4, 1);
            optionsScreen.changeTileWeight(4, 1);
            optionsScreen.changeTileWeight(5, -1);
            optionsScreen.changeTileWeight(5, -1);
            Assert.AreEqual(10, optionsScreen.getTileWeights()[0]);
            Assert.AreEqual(5, optionsScreen.getTileWeights()[1]);
            Assert.AreEqual(1, optionsScreen.getTileWeights()[2]);
            Assert.AreEqual(3, optionsScreen.getTileWeights()[3]);
            Assert.AreEqual(4, optionsScreen.getTileWeights()[4]);
            Assert.AreEqual(1, optionsScreen.getTileWeights()[5]);
        }

        [TestMethod]
        public void TestTileWeightParameter()
        {
            List<int[]> arrays = ParameterValues.Singleton().TileWeightArray;
            List<int> answers = ParameterValues.Singleton().TileWeightAnswer;

            for (int i = 0; i < answers.Count; i++)
            {
                optionsScreen.Reset();
                TestTileWeightHelper(arrays[i], answers[i]);
            }
        }

        private void TestTileWeightHelper(int[] array, int answer)
        {
            foreach (int n in array)
            {
                optionsScreen.changeTileWeight(0, n);
            }
            Assert.AreEqual(answer, optionsScreen.getTileWeights()[0]);
        }
    }
}
