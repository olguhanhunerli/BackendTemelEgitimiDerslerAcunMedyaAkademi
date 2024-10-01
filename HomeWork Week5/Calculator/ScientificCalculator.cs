
using System;

namespace CalculatorApplication
{
    public class ScientificCalculator : Calculator
    {
        public double Sin(double angle)
        {
            return Math.Sin(angle);
        }

        public double Cos(double angle)
        {
            return Math.Cos(angle);
        }
    }
}
