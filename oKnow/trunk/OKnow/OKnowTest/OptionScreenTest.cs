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
		/// <summary>
        /// Tests board size generation
        ///</summary>
        [TestMethod]
        public void TestGetBoardSize1()
        {
            Assert.AreEqual(BoardSize.SMALL, optionsScreen.GetCurrentBoardSize());
        }
		/// <summary>
        /// Tests board size generation
        ///</summary>
        [TestMethod]
        public void TestGetBoardSize2()
        {
            optionsScreen.ChangeBoardSize(1);
            Assert.AreEqual(BoardSize.MEDIUM, optionsScreen.GetCurrentBoardSize());
        }
		/// <summary>
        /// Tests board size generation
        ///</summary>
        [TestMethod]
        public void TestGetBoardSize3()
        {
            optionsScreen.ChangeBoardSize(1);
            optionsScreen.ChangeBoardSize(1);
            Assert.AreEqual(BoardSize.LARGE, optionsScreen.GetCurrentBoardSize());
        }
		/// <summary>
        /// Tests board size generation
        ///</summary>
        [TestMethod]
        public void TestGetBoardSize4()
        {
            optionsScreen.ChangeBoardSize(1);
            optionsScreen.ChangeBoardSize(1);
            optionsScreen.ChangeBoardSize(1);
            Assert.AreEqual(BoardSize.SMALL, optionsScreen.GetCurrentBoardSize());
        }
		/// <summary>
        /// Tests board size generation
        ///</summary>
        [TestMethod]
        public void TestGetBoardSize5()
        {
            optionsScreen.ChangeBoardSize(-1);
            Assert.AreEqual(BoardSize.LARGE, optionsScreen.GetCurrentBoardSize());
        }
		/// <summary>
        /// Tests board size generation
        ///</summary>
        [TestMethod]
        public void TestGetBoardSize6()
        {
            optionsScreen.ChangeBoardSize(-1);
            optionsScreen.ChangeBoardSize(1);
            optionsScreen.ChangeBoardSize(1);
            Assert.AreEqual(BoardSize.MEDIUM, optionsScreen.GetCurrentBoardSize());
        }
		/// <summary>
        /// Tests board size generation
        ///</summary>
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
		/// <summary>
        /// Tests board size generation
        ///</summary>
        private void TestBoardSizeHelper(int[] array, BoardSize answer)
        {
            foreach (int n in array)
            {
                optionsScreen.ChangeBoardSize(n);
            }
            Assert.AreEqual(answer, optionsScreen.GetCurrentBoardSize());
        }
		/// <summary>
        /// Tests board type generation
        ///</summary>
        [TestMethod]
        public void TestGetBoardType1()
        {
            Assert.AreEqual(BoardType.STANDARD, optionsScreen.GetCurrentBoardType());
        }
		/// <summary>
        /// Tests board type generation
        ///</summary>
        [TestMethod]
        public void TestGetBoardType2()
        {
            optionsScreen.ChangeBoardType(1);
            Assert.AreEqual(BoardType.RANDOM, optionsScreen.GetCurrentBoardType());
        }
		/// <summary>
        /// Tests board type generation
        ///</summary>
        [TestMethod]
        public void TestGetBoardType3()
        {
            optionsScreen.ChangeBoardType(-1);
            Assert.AreEqual(BoardType.RANDOM, optionsScreen.GetCurrentBoardType());
        }
		/// <summary>
        /// Tests board type generation
        ///</summary>
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
		/// <summary>
        /// Tests board type generation
        ///</summary>
        private void TestBoardTypeHelper(int[] array, BoardType answer)
        {
            foreach (int n in array)
            {
                optionsScreen.ChangeBoardType(n);
            }
            Assert.AreEqual(answer, optionsScreen.GetCurrentBoardType());
        }
		/// <summary>
        /// Tests tile weight generation
        ///</summary>
        [TestMethod]
        public void TestGetTileWeights1()
        {
            Assert.AreEqual(10, optionsScreen.GetTileWeights()[0]);
            Assert.AreEqual(3, optionsScreen.GetTileWeights()[1]);
            Assert.AreEqual(3, optionsScreen.GetTileWeights()[2]);
            Assert.AreEqual(3, optionsScreen.GetTileWeights()[3]);
            Assert.AreEqual(2, optionsScreen.GetTileWeights()[4]);
            Assert.AreEqual(2, optionsScreen.GetTileWeights()[5]);
        }
		/// <summary>
        /// Tests tile weight generation
        ///</summary>
        [TestMethod]
        public void TestGetTileWeights2()
        {
            optionsScreen.ChangeTileWeight(1, 1);
            Assert.AreEqual(10, optionsScreen.GetTileWeights()[0]);
            Assert.AreEqual(4, optionsScreen.GetTileWeights()[1]);
            Assert.AreEqual(3, optionsScreen.GetTileWeights()[2]);
            Assert.AreEqual(3, optionsScreen.GetTileWeights()[3]);
            Assert.AreEqual(2, optionsScreen.GetTileWeights()[4]);
            Assert.AreEqual(2, optionsScreen.GetTileWeights()[5]);
        }
		/// <summary>
        /// Tests tile weight generation
        ///</summary>
        [TestMethod]
        public void TestGetTileWeights3()
        {
            optionsScreen.ChangeTileWeight(1, 1);
            optionsScreen.ChangeTileWeight(1, 1);
            optionsScreen.ChangeTileWeight(1, 1);
            Assert.AreEqual(10, optionsScreen.GetTileWeights()[0]);
            Assert.AreEqual(5, optionsScreen.GetTileWeights()[1]);
            Assert.AreEqual(3, optionsScreen.GetTileWeights()[2]);
            Assert.AreEqual(3, optionsScreen.GetTileWeights()[3]);
            Assert.AreEqual(2, optionsScreen.GetTileWeights()[4]);
            Assert.AreEqual(2, optionsScreen.GetTileWeights()[5]);
        }
		/// <summary>
        /// Tests tile weight generation
        ///</summary>
        [TestMethod]
        public void TestGetTileWeights4()
        {
            optionsScreen.ChangeTileWeight(1, 1);
            optionsScreen.ChangeTileWeight(1, 1);
            optionsScreen.ChangeTileWeight(2, -1);
            optionsScreen.ChangeTileWeight(2, -1);
            Assert.AreEqual(10, optionsScreen.GetTileWeights()[0]);
            Assert.AreEqual(5, optionsScreen.GetTileWeights()[1]);
            Assert.AreEqual(1, optionsScreen.GetTileWeights()[2]);
            Assert.AreEqual(3, optionsScreen.GetTileWeights()[3]);
            Assert.AreEqual(2, optionsScreen.GetTileWeights()[4]);
            Assert.AreEqual(2, optionsScreen.GetTileWeights()[5]);
        }
		/// <summary>
        /// Tests tile weight generation
        ///</summary>
        [TestMethod]
        public void TestGetTileWeights5()
        {
            optionsScreen.ChangeTileWeight(0, -1);
            optionsScreen.ChangeTileWeight(0, -1);
            optionsScreen.ChangeTileWeight(0, -1);
            optionsScreen.ChangeTileWeight(0, -1);
            optionsScreen.ChangeTileWeight(0, -1);
            optionsScreen.ChangeTileWeight(0, -1);
            optionsScreen.ChangeTileWeight(0, -1);
            optionsScreen.ChangeTileWeight(0, -1);
            optionsScreen.ChangeTileWeight(2, -1);
            optionsScreen.ChangeTileWeight(2, -1);
            Assert.AreEqual(2, optionsScreen.GetTileWeights()[0]);
            Assert.AreEqual(3, optionsScreen.GetTileWeights()[1]);
            Assert.AreEqual(1, optionsScreen.GetTileWeights()[2]);
            Assert.AreEqual(3, optionsScreen.GetTileWeights()[3]);
            Assert.AreEqual(2, optionsScreen.GetTileWeights()[4]);
            Assert.AreEqual(2, optionsScreen.GetTileWeights()[5]);
        }
		/// <summary>
        /// Tests tile weight generation
        ///</summary>
        [TestMethod]
        public void TestGetTileWeights6()
        {
            optionsScreen.ChangeTileWeight(1, 1);
            optionsScreen.ChangeTileWeight(1, 1);
            optionsScreen.ChangeTileWeight(2, -1);
            optionsScreen.ChangeTileWeight(4, 1);
            optionsScreen.ChangeTileWeight(4, 1);
            optionsScreen.ChangeTileWeight(5, -1);
            optionsScreen.ChangeTileWeight(5, -1);
            Assert.AreEqual(10, optionsScreen.GetTileWeights()[0]);
            Assert.AreEqual(5, optionsScreen.GetTileWeights()[1]);
            Assert.AreEqual(1, optionsScreen.GetTileWeights()[2]);
            Assert.AreEqual(3, optionsScreen.GetTileWeights()[3]);
            Assert.AreEqual(4, optionsScreen.GetTileWeights()[4]);
            Assert.AreEqual(1, optionsScreen.GetTileWeights()[5]);
        }
		/// <summary>
        /// Tests tile weight generation
        ///</summary>
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
		/// <summary>
        /// Tests tile weight generation
        ///</summary>
        private void TestTileWeightHelper(int[] array, int answer)
        {
            foreach (int n in array)
            {
                optionsScreen.ChangeTileWeight(0, n);
            }
            Assert.AreEqual(answer, optionsScreen.GetTileWeights()[0]);
        }
    }
}
