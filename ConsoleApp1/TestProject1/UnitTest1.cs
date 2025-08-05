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
            Assert.That(calc.Add(2, 3), Is.EqualTo(5));
        }

        [Test]
        public void Subtract_SimpleValues_ReturnsDifference()
        {
            Assert.That(calc.Subtract(3, 2), Is.EqualTo(1));
        }

        [Test]
        public void Multiply_SimpleValues_ReturnsProduct()
        {
            Assert.That(calc.Multiply(2, 3), Is.EqualTo(6));
        }

        [Test]
        public void Divide_SimpleValues_ReturnsQuotient()
        {
            Assert.That(calc.Divide(6, 3), Is.EqualTo(2));
        }

        [Test]
        public void Divide_DivideByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => calc.Divide(6, 0));
        }
    }
}
