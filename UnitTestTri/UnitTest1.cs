using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTri
{
    [TestClass]
    public class TriangleUnitTest
    {    
        [TestMethod]//Scalene, Inga lika
        public void isScaleneTrue()
        {
            Triangle tri = new Triangle(3.0, 4.0, 5.0);
            Assert.IsTrue(tri.isScalene());
        }
        [TestMethod]
        public void isScaleneFalse()
        {
            Triangle tri = new Triangle(2, 2, 3);
            Assert.IsFalse(tri.isScalene());
        }
        [TestMethod]//Isosceles likbent
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
        [TestMethod]//Equilateral liksidig
        public void isEquilateralTrue()
        {
            Triangle tri = new Triangle(1.56272198423136, 1.56272198423136, 1.56272198423136);
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
        [TestMethod]//Testar om konstruktorn kan ta in 2 tal i en array
        public void TestArrayWithTwoInput()
        {
            try 
            {
                new Triangle(new Point[] { new Point(4, 4), new Point(5, 5) });
                Assert.Fail("no exception thrown");//Kommer koden hit har inget exception kastats
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is Exception);
            }
        }
        [TestMethod]//Testar om konstruktorn kan ta in fler än 3 tal
        public void TestArrayWithFiveInput()
        {
            try
            {
                new Triangle(new Point[] { new Point(4, 4), new Point(5, 5), new Point(5, 5), new Point(3, 3), new Point(6, 6) });
                Assert.Fail("no exception thrown");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex is Exception);
            }
        }
        [TestMethod]//Testar om konstruktorn kan ta in 3 points
        public void TestThreePointConstruct()
        {
            new Triangle(new Point(3, 3), new Point(4, 4), new Point(5, 5));
        }
        [TestMethod]//Testar loop konstruktorn
        public void TestLoopConstruct()
        {
            double[] array = new double[3];
            Triangle tri = new Triangle(array);
        }
    }
}
