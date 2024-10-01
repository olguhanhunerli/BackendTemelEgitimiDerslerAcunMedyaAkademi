
using System;

namespace CalculatorApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Add(5, 3));
            Console.WriteLine(calculator.Subtract(10, 6));
        }
    }
}
