using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTri
{
    [TestClass]
    public class TriangleUnitTest
    {   //Ska lyckas
        //Scalene
        [TestMethod]
        public void isScaleneTrue()
        {
            Triangle tri = new Triangle(1.132, 1.132, 1.132);
            Assert.IsTrue(tri.isScalene());
        }
        [TestMethod]
        public void isScaleneFalse()
        {
            Triangle tri = new Triangle(1, 1, 2);
            Assert.IsFalse(tri.isScalene());
        }
        //Isosceles
        [TestMethod]
        public void isIsoscelesTrue()
        {
            Triangle tri = new Triangle(1.0, 1.4142135623730951, 1.0);
            Assert.IsTrue(tri.isIsosceles());
        }
        [TestMethod]
        public void isIsoscelesFalse()
        {
            Triangle tri = new Triangle(1.0, 1.0, 1.0);
            Assert.IsFalse(tri.isIsosceles());
        }
        //Equilateral
        [TestMethod]
        public void isEquilateralTrue()
        {
            Triangle tri = new Triangle(1.1, 1.11, 1.5627219842313604);
            Assert.IsTrue(tri.isEquilateral());
        }
        [TestMethod]
        public void isEquilateralFalse()
        {
            Triangle tri = new Triangle(1.1, 1.11, 1.1);
            Assert.IsFalse(tri.isEquilateral());
        }
        [TestMethod]
        public void TestFullArray()
        {
            new Triangle(new Point[] { new Point(3, 3), new Point(4, 4), new Point(5, 5) });
        }
        [TestMethod]
        public void TestThreePointConst()
        {
            new Triangle(new Point(3, 3), new Point(4, 4), new Point(5, 5));
        }
        //[TestMethod]
        //public void TestLoopConst()
        //{
        //    new Triangle(, 4);
        //}
    }
}
