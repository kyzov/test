// Calculator.cs
using System;

namespace CalculatorApp
{
    public class Calculator
    {
        public double Add(double x, double y) => x + y;

        public double Subtract(double x, double y) => x - y;

        public double Multiply(double x, double y) => x * y;

        public double Divide(double x, double y)
        {
            if (y == 0)
                throw new DivideByZeroException("division by zero");
            return x / y;
        }
    }
}
