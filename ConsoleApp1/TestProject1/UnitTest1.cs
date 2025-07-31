// CalculatorTests.cs
using NUnit.Framework;
using System;
using ConsoleApp1;

namespace TestProject1
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calc;

        [SetUp]
        public void Setup()
        {
            calc = new Calculator();
        }

        [Test]
        public void Add_SimpleValues_ReturnsSum()
        {
            Assert.AreEqual(5, calc.Add(2, 3));
        }

        [Test]
        public void Subtract_SimpleValues_ReturnsDifference()
        {
            Assert.AreEqual(1, calc.Subtract(3, 2));
        }

        [Test]
        public void Multiply_SimpleValues_ReturnsProduct()
        {
            Assert.AreEqual(6, calc.Multiply(2, 3));
        }

        [Test]
        public void Divide_SimpleValues_ReturnsQuotient()
        {
            Assert.AreEqual(2, calc.Divide(6, 3));
        }

        [Test]
        public void Divide_DivideByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => calc.Divide(6, 0));
        }
    }
}
