using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RotatingWalkInMatrix;

namespace MatrixTests
{
    [TestClass]
    public class MatrixTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Size must be between 1 and 100!")]
        public void TestMatrix_WithSize0()
        {
            Matrix rotationWalk = new Matrix(0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "Size must be between 1 and 100!")]
        public void TestMatrix_WithSize101()
        {
            Matrix rotationWalk = new Matrix(101);
        }

        [TestMethod]
        public void TestMatrix_WithSize6()
        {
            Matrix rotationWalk = new Matrix(6);

            Assert.AreEqual(string.Format("{0}{6}{1}{6}{2}{6}{3}{6}{4}{6}{5}{6}",
                                                            "  1 16 17 18 19 20",
                                                            " 15  2 27 28 29 21",
                                                            " 14 31  3 26 30 22",
                                                            " 13 36 32  4 25 23",
                                                            " 12 35 34 33  5 24",
                                                            " 11 10  9  8  7  6",
                                                            Environment.NewLine), 
                            rotationWalk.ToString());
        }
    }
}
