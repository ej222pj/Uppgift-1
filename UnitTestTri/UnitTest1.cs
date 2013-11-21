using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTri
{
    [TestClass]
    public class TriangleUnitTest
    {
        [TestMethod]//Ska lyckas
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
        }//Nedanstående tester ska misslyckas
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void LessThanThreePoints()
        {
            new Triangle(new[] { new Point(0, 0), new Point(1, 1) });
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MoreThanThreePoints()
        {
            new Triangle(new[] { new Point(0, 0), new Point(1, 1), new Point(2, 2), new Point(3, 3) });
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TwoIdenticalPoints()
        {
            new Triangle(new[] { new Point(0, 0), new Point(0, 0), new Point(1, 1) });
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void EmptyArray()
        {
            new Triangle(new Point[] { });
        }
    }
}
