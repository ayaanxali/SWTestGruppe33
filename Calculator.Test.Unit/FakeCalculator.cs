using System;
using System.Collections.Generic;
using System.Text;
using L1_Calculator;

namespace Calculator.Test.Unit
{
    public class FakeCalculator : ICalculator
    {
        public bool IsActivated { get; set; }
        public void Add(double a, double b)
        {
            IsActivated = true;
            
        }
    }
}
