using System;
using NUnit.Framework;
using Lab1_Stru_IVT_7;


namespace Lab1_Stru_IVT_7.Tests
{
    [TestFixture]
    public class TriangleTest
    {
        [Test]
        [TestCase(-20.0, 15.0, 34.0)]
        [TestCase(11.0, -7.0, 9.0)]
        [TestCase(10.0, 8.0, -5.0)]
        public void TriangleFormatException(double a, double b, double c)
        {

            Assert.Throws<FormatException>(() => new Triangle(a, b, c));
        }

        [Test]
        [TestCase(25.0, 8.0, 7.0)]
        [TestCase(8.0, 25.0, 7.0)]
        [TestCase(7.0, 8.0, 25.0)]
        [TestCase(25.0, 8.0, 7.0)]
        [TestCase(8.0, 7.0, 25.0)]
        [TestCase(8.0, 25.0, 7.0)]
        public void TriangleNotExist(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Test]
        [TestCase(-20.0, 15.0, 34.0)]
        [TestCase(11.0, -7.0, 9.0)]
        [TestCase(10.0, 8.0, -5.0)]
        public void SetSideFormatException(double a, double b, double c)
        {
            Triangle triangle = new Triangle();
            Assert.Throws<FormatException>(() => triangle.SetSides(a, b, c));
        }

        [Test]
        [TestCase(25.0, 8.0, 7.0)]
        [TestCase(8.0, 25.0, 7.0)]
        [TestCase(7.0, 8.0, 25.0)]
        [TestCase(25.0, 8.0, 7.0)]
        [TestCase(8.0, 7.0, 25.0)]
        [TestCase(8.0, 25.0, 7.0)]
        public void SedSideNotExist(double a, double b, double c)
        {
            Triangle triangle = new Triangle();
            Assert.Throws<ArgumentException>(() => triangle.SetSides(a, b, c));
        }

        [Test]
        [TestCase(2.0, 3.0, 4.0)]
        [TestCase(2.0, 4.0, 3.0)]
        [TestCase(3.0, 2.0, 4.0)]
        [TestCase(3.0, 4.0, 2.0)]
        [TestCase(4.0, 3.0, 2.0)]
        [TestCase(4.0, 2.0, 3.0)]
        public void TestArea(double a, double b, double c)
        {
            Triangle triangle = new Triangle(a, b, c);
            Assert.AreEqual(2.9, triangle.Area());
        }

        [Test]
        [TestCase(2.0, 3.0, 4.0)]
        [TestCase(2.0, 4.0, 3.0)]
        [TestCase(3.0, 2.0, 4.0)]
        [TestCase(3.0, 4.0, 2.0)]
        [TestCase(4.0, 3.0, 2.0)]
        [TestCase(4.0, 2.0, 3.0)]
        public void TestArea1(double a, double b, double c)
        {
            Triangle triangle = new Triangle();
            triangle.SetSides(a, b, c);
            Assert.AreEqual(2.9, triangle.Area());
        }
    }
}