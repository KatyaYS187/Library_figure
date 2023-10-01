using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq.Expressions;
using System;


namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void The_Triangle_Is_Rectangular()
        {
           
            var triangle = new Triangle(3,4,5);
            var result = triangle.GetArea();
            double expected = 6;
            Assert.AreEqual(expected, result);
            
            
        }

        [TestMethod]
        public void The_Triangle_Is_Not_Rectangular() 
        {
            var triangles = new Triangle(6, 8, 9);
            var results = triangles.isStraightTriangle();
            Assert.IsFalse(results);
        }


        [TestMethod]
        public void Exception_To_Zero() //вызовется исключение, т.к. площадь = 0
        {

            var triangle = new Triangle(1, 2, 3);
            var result = triangle.GetArea();
            double expected = 0;
            Assert.AreEqual(expected, result);


        }

        [TestMethod]
        public void Circle_Check()
        {
            var circle = new Circle(12);
            var expected = 452.39;
            var result = circle.GetArea();
            Assert.AreEqual(expected, result);
        }
    }
}