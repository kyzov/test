using System;

namespace ConsoleApp1
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

    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();

            Console.WriteLine("2 + 3 = " + calc.Add(2, 3));
            Console.WriteLine("5 - 2 = " + calc.Subtract(5, 2));
            Console.WriteLine("4 * 3 = " + calc.Multiply(4, 3));
            Console.WriteLine("10 / 2 = " + calc.Divide(10, 2));
        }
    }
}
