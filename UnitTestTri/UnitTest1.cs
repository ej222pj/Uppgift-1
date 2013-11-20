using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTri
{
    [TestClass]
    public class TriangleUnitTest
    {
        [TestMethod]
        public void isScalene()
        {
            Triangle tri = new Triangle(1.132, 1.132, 1.132);
            Assert.IsTrue(tri.isScalene());
        }
        [TestMethod]
        public void isIsosceles()
        {
            Triangle tri = new Triangle(1.0, 1.4142135623730951, 1.0);
            Assert.IsTrue(tri.isIsosceles());
        }
        [TestMethod]
        public void isEquilateral()
        {
            Triangle tri = new Triangle(1.1, 1.11, 1.5627219842313604);
            Assert.IsTrue(tri.isEquilateral());
        }
    }
}
