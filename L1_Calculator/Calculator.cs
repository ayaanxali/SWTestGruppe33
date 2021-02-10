using System;
using System.Collections.Generic;
using System.Text;

namespace L1_Calculator
{
    public class Calculator 
    {
        public double Accumulator { get; private set; }

        public Calculator()
        {
            Accumulator = 0;
        }

        public void Add(double a, double b)
        {
            Accumulator = a + b;
           // return Accumulator;
        }

        public void Add(double a)
        {
            double value = Accumulator;
            Accumulator = a + value;
        }

        public void Subtract(double a, double b)
        {
            Accumulator = a - b;
            //return Accumulator;
        }

        public void Subtract(double a)
        {
            double value = Accumulator;
            Accumulator = a - value;
        }

        public void Multiply(double a, double b)
        {
            Accumulator = a * b;
            //return a * b;
        }

        public void MultiPly(double a)
        {
            double value = Accumulator;
            Accumulator = a * value;
        }

        public void Power(double x, double y)
        {
            Accumulator = Math.Pow(x, y);
        }

        public void Power(double x)
        {
            double value = Accumulator;
            Accumulator =Math.Pow(x, value);
        }

        public void Clear()
        {
            Accumulator = 0;
        }

    }
}
