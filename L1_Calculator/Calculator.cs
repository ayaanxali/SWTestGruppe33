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

        public double Add(double a, double b)
        {
            return Accumulator = a + b;
        }

        public double Add(double a)
        {
            double value = Accumulator;
            return Accumulator = a + value;
            
        }

        public double Subtract(double a, double b)
        {
           return Accumulator = a - b;
        }

        public double Subtract(double a)
        {
            double value = Accumulator;
            return Accumulator = a - value;
        }

        public double Multiply(double a, double b)
        {
           return Accumulator = a * b;
        }

        public double MultiPly(double a)
        {
            double value = Accumulator;
            return Accumulator = a * value;
        }

        public double Division(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException();

            return Accumulator = a / b;
        }

        public double Division(double a)
        {
            double value = Accumulator;
            return Accumulator = a / value;
        }

        public double Power(double x, double y)
        {
            return Accumulator = Math.Pow(x, y);
        }

        public double Power(double x)
        {
            double value = Accumulator;
           return Accumulator =Math.Pow(x, value);
        }

        public double Clear()
        {
            return Accumulator = 0;
        }

    }
}
