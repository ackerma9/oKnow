using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OKnow;

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

        [TestMethod]
        public void TestSum1()
        {
            Assert.AreEqual(10, BoardGenerator.sum(0));
        }

        [TestMethod]
        public void TestSum2()
        {
            Assert.AreEqual(13, BoardGenerator.sum(1));
        }

        [TestMethod]
        public void TestSum3()
        {
            Assert.AreEqual(16, BoardGenerator.sum(2));
        }

        [TestMethod]
        public void TestSum4()
        {
            Assert.AreEqual(19, BoardGenerator.sum(3));
        }

        [TestMethod]
        public void TestSum5()
        {
            Assert.AreEqual(21, BoardGenerator.sum(4));
        }

        [TestMethod]
        public void TestSum6()
        {
            Assert.AreEqual(23, BoardGenerator.sum(5));
        }

        [TestMethod]
        public void TestSum7()
        {
            Assert.AreEqual(0, BoardGenerator.sum(6));
        }
    }
}
