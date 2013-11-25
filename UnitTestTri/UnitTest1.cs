using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTri
{
    [TestClass]
    public class TriangleUnitTest
    {    
        [TestMethod]//Scalene
        public void isScaleneTrue()
        {
            Triangle tri = new Triangle(1.132, 2.132, 3.132);
            Assert.IsTrue(tri.isScalene());
        }
        [TestMethod]
        public void isScaleneFalse()
        {
            Triangle tri = new Triangle(1, 1, 2);
            Assert.IsFalse(tri.isScalene());
        }
        [TestMethod]//Isosceles
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
        [TestMethod]//Equilateral
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
        [TestMethod]//Testar om konstruktorn kan ta in en hel array
        public void TestFullArray()
        {
            new Triangle(new Point[] { new Point(3, 3), new Point(4, 4), new Point(5, 5) });
        }
        [TestMethod]//Testar om konstruktorn kan ta in 3 points
        public void TestThreePointConstruct()
        {
            new Triangle(new Point(3, 3), new Point(4, 4), new Point(5, 5));
        }
        [TestMethod]//Testar loop konstruktorn
        public void TestLoopConstruct()
        {
            double[] array = new double[5];
            Triangle tri = new Triangle(array);
        }
    }
}
