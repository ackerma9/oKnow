using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OKnow;
using OKnow.Board;
namespace OKnowTest
{
    [TestClass]
    public class BoardGeneratorTest
    {
        /// <summary>
        ///Initialize() is called once during test execution before each
        ///test method in this test class are executed.
        ///</summary>
        [TestInitialize()]
        public void Initialize()
        {
            BoardGenerator.tileWeights = new int[] { 10, 3, 3, 3, 2, 2 };
        }
		/// <summary>
        /// Tests the sum function in board generator
        ///</summary>
        [TestMethod]
        public void TestSum1()
        {
            Assert.AreEqual(10, BoardGenerator.Sum(0));
        }
		/// <summary>
        /// Tests the sum function in board generator
        ///</summary>
        [TestMethod]
        public void TestSum2()
        {
            Assert.AreEqual(13, BoardGenerator.Sum(1));
        }
		/// <summary>
        /// Tests the sum function in board generator
        ///</summary>
        [TestMethod]
        public void TestSum3()
        {
            Assert.AreEqual(16, BoardGenerator.Sum(2));
        }
		/// <summary>
        /// Tests the sum function in board generator
        ///</summary>
        [TestMethod]
        public void TestSum4()
        {
            Assert.AreEqual(19, BoardGenerator.Sum(3));
        }
		/// <summary>
        /// Tests the sum function in board generator
        ///</summary>
        [TestMethod]
        public void TestSum5()
        {
            Assert.AreEqual(21, BoardGenerator.Sum(4));
        }
		/// <summary>
        /// Tests the sum function in board generator
        ///</summary>
        [TestMethod]
        public void TestSum6()
        {
            Assert.AreEqual(23, BoardGenerator.Sum(5));
        }
		/// <summary>
        /// Tests the sum function in board generator
        ///</summary>
        [TestMethod]
        public void TestSum7()
        {
            Assert.AreEqual(0, BoardGenerator.Sum(6));
        }
    }
}
