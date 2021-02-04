using System;
using System.Collections.Generic;
using System.Text;

namespace L1_Calculator
{
    public class Calculator : ICalculator
    {

        public Calculator()
        {

        }


        public double Add(double a, double b)
        {
            double value = a + b;
            return value;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }

    }
}
