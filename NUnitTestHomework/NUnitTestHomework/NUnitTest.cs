using System;
using NUnit.Framework;
using CalculatorAppHomework;

namespace NUnitTestHomework
{
    [TestFixture]
    public class NUnitTest
    {
        [Test]
        public void TestAdd()
        {
            
            CalculatorApp calc = new CalculatorApp();
            double expected = 6.0;
            double actual = calc.Add(2.0, 4.0);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestDivide()
        {
            CalculatorApp calc = new CalculatorApp();
            double expected = 2.0;
            double actual = calc.Divide(4.0, 2.0);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestSubtract()
        {
            CalculatorApp calc = new CalculatorApp();
            double expected = 2.0;
            double actual = calc.Subtract(4.0, 2.0);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TestMultiply()
        {
            CalculatorApp calc = new CalculatorApp();
            double expected = 8.0;
            double actual = calc.Multiply(4.0, 2.0);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ModularTest()
        {
            CalculatorApp calc = new CalculatorApp();
            double expected = 0.0;
            double actual = calc.Modular(4.0, 2.0);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void TriangleTest()
        {
            CalculatorApp calc = new CalculatorApp();
            double expected = 4.0;
            double actual = calc.Triangle(4.0, 2.0);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void CircleTest()
        {
            CalculatorApp calc = new CalculatorApp();
            double expected = 50.272;
            double actual = calc.Circle(4.0);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void SquareTest()
        {
            CalculatorApp calc = new CalculatorApp();
            double expected = 16.0;
            double actual = calc.Square(4.0, 4.0);
            Assert.AreEqual(expected, actual);
        }
    }
}
