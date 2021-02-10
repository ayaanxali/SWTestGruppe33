using System.Runtime.InteropServices.ComTypes;
using NUnit.Framework;
using Calculator;
using L1_Calculator;
using Calculator = L1_Calculator.Calculator;

namespace Calculator.Test.Unit
{
    public class Tests
    {
        private L1_Calculator.Calculator uut;
        //private ICalculator calculator;
        [SetUp]
        public void Setup()
        {
            uut = new L1_Calculator.Calculator();
            //calculator = new FakeCalculator();//ready for expansion of code
        }

        [TestCase(-6,-2,-4)]
        [TestCase(5, 2, 3)]
        [TestCase(-1, -4, 3)]
        public void Add_DoAddAWithB_IsExpectedResult(double ExpectedResult, double InputA, double InputB)
        {
            double value = uut.Add(InputA, InputB);

            Assert.That(value,Is.EqualTo(ExpectedResult));
        }

        //[TestCase(5, 2,3)]
        //public void Add_DoAddAWithB_1IsExpectedResult(double ExpectedResult, double InputA, double InputB)
        //{
        //    double value = uut.Add(InputA, InputB);

        //    Assert.That(value, Is.EqualTo(ExpectedResult));
        //}

        //[TestCase(-1, -4,3)]
        //public void Add_DoAddAWithB_2IsExpectedResult(double ExpectedResult, double InputA, double InputB)
        //{
        //    double value = uut.Add(-4, 3);

        //    Assert.That(value, Is.EqualTo(ExpectedResult));
        //}
        [TestCase(10,4,6)]
        [TestCase(-10, 4, -14)]
        [TestCase(-10, -4, -6)]
        public void Subtract_MethodDoSubstractAWithB_IsExpectedResult(double varA,double varB,double expectedResult)
        {
            double value = uut.Subtract(varA, varB);

            Assert.That(value, Is.EqualTo(expectedResult));
        }
        [TestCase(40, 10,4)]
        [TestCase(-40, 10, -4)]
        [TestCase(50, -10, -5)]
        public void Multiply_MethodDoMultiplyAWithB_IsExpectedResult(double ExpectedResult, double InputA, double InputB)
        {
            double value = uut.Multiply(InputA, InputB);

            Assert.That(value, Is.EqualTo(ExpectedResult));
        }
        [TestCase(8,2,3)]
        [TestCase(-8, -2, 3)]
        [TestCase(-0.125, -2, -3)]
        public void Power_MethodDoPowerAwithB_IsPectedResult(double ExpectedResult, double InputA, double InputB)
        {
            double value = uut.Power(InputA, InputB);

            Assert.That(value, Is.EqualTo(ExpectedResult));
        }

    }
}