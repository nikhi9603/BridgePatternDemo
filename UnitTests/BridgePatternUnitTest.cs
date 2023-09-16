using BridgePattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTests
{
    [TestClass]
    public class BridgePatternUnitTest
    {
        [TestMethod]
        public void ValidDetailedCircleTest()
        {
            double radius = 2;
            
            Shapes circle1 = new Circle(new DetailedView() , radius);
            Shapes circle2 = new Circle(radius);

            List<string> result1 = circle1.Display();
            List<string> result2 = circle2.Display();
            
            Assert.IsTrue(result1.Count == 4);

            Assert.AreEqual(result1[0], "Detailed View of Circle");
            Assert.AreEqual(result1[1], $"Drawing Circle with radius 2 units");
            Assert.AreEqual(result1[2], $"Area of Circle = {Math.PI *  radius* radius} sq.units");
            Assert.AreEqual(result1[3], $"Perimeter of Circle = {2 * Math.PI * radius} units");

            Assert.AreEqual(result1.Count, result2.Count);
        }

        [TestMethod]
        public void ValidBriefCircleTest() 
        {
            double radius = 2;

            Shapes circle = new Circle(new BriefView() , radius);

            List<string> result = circle.Display();

            Assert.IsTrue(result.Count == 2);

            Assert.AreEqual(result[0], "Brief View of Circle");
            Assert.AreEqual(result[1], $"Drawing Circle with radius 2 units");
        }

        [TestMethod]
        public void ValidDetailSquareTest() 
        {
            double length = 4.5 ;

            Shapes square1 = new Square(new DetailedView() , length);
            Shapes square2 = new Square(length);

            List<string> result1 = square1.Display();
            List<string> result2 = square2.Display();

            Assert.IsTrue(result1.Count == 4);

            Assert.AreEqual(result1[0], "Detailed View of Square");
            Assert.AreEqual(result1[1], $"Drawing Square with length 4.5 units");
            Assert.AreEqual(result1[2], $"Area of Square = {length * length} sq.units");
            Assert.AreEqual(result1[3], $"Perimeter of Square = {4 * length} units");

            Assert.AreEqual(result1.Count, result2.Count);
        }

        [TestMethod]
        public void ValidBriefSquareTest()
        {
            double length =  4.5 ;

            Shapes square = new Square(new BriefView() , length);

            List<string> result = square.Display();

            Assert.IsTrue(result.Count == 2);

            Assert.AreEqual(result[0], "Brief View of Square");
            Assert.AreEqual(result[1], $"Drawing Square with length 4.5 units");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException) , "Invalid radius of Circle")]
        public void InvalidCircleTest()
        {
            double radius = -2;

            Shapes _ = new Circle(new DetailedView(), radius);

            Assert.Fail("Argument Exception was not raised for invalid radius");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException) , "Invalid length of square")]
        public void InvalidSquareTest()
        {
            double length = -3.2;

            Shapes _ = new Square(new DetailedView() , length);

            Assert.Fail("Argument Exception was not raised for invalid length");
        }
    }
}
