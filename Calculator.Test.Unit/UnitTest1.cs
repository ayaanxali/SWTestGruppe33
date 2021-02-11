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

        [TestCase(10,5,3,2)]
        [TestCase(22,-2,20,4)]
        [TestCase(-18,-2,-20,4)]
        [TestCase(-26,-2,-20,-4)]
        public void Add_MethodOverloadDoAddAWithAccumulator_IsExpectedResult(double ExpectedResult, double InputA,
            double InputB, double InputA2)
        {
            uut.Add(InputA, InputB);
            double value = uut.Add(InputA2);

            Assert.That(value, Is.EqualTo(ExpectedResult));
        }

        [TestCase(10,4,6)]
        [TestCase(-10, 4, -14)]
        [TestCase(-10, -4, -6)]
        public void Subtract_MethodDoSubstractAWithB_IsExpectedResult(double varA,double varB,double expectedResult)
        {
            double value = uut.Subtract(varA, varB);

            Assert.That(value, Is.EqualTo(expectedResult));
        }
        [TestCase(10, 5, 3, 2)]
        [TestCase(22, -2, 20, 4)]
        [TestCase(-18, -2, -20, 4)]
        [TestCase(-26, -2, -20, -4)]
        public void Subtract_MethodOverloadDoAddAWithAccumulator_IsExpectedResult(double ExpectedResult, double InputA,
            double InputB, double InputA2)
        {
            uut.Add(InputA, InputB);
            double value = uut.Add(InputA2);

            Assert.That(value, Is.EqualTo(ExpectedResult));
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
        public void Power_MethodDoPowerAwithB_IsExpectedResult(double ExpectedResult, double InputA, double InputB)
        {
            double value = uut.Power(InputA, InputB);

            Assert.That(value, Is.EqualTo(ExpectedResult));
        }
        [TestCase(5, 10, 2)]
        [TestCase(-10, 50, -5)]
        [TestCase(10, -50, -5)]
        public void Division_MethodDoDivideAwithB_IsExpectedResult(double ExpectedResult, double InputA, double InputB)
        {
            double value = uut.Division(InputA, InputB);

            Assert.That(value, Is.EqualTo(ExpectedResult));
        }

        [TestCase(5,50,5,2)]
        [TestCase(15.625,250,5,3.2)]
        public void Division_MethodOverloadDoDivideAWithAccumulator_IsExpectedResult(double ExpectedResult, double InputA, double InputB, double InputA2)
        {
            uut.Division(InputA,InputB);
            double value= uut.Division(InputA2);

            Assert.That(value, Is.EqualTo(ExpectedResult));
        }
        [TestCase(10, 2, 3,5,5)]
        public void Accumulator_MethodTestAccumulator_IsExpectedResult(double ExpectedResult, double InputA,
            double InputB, double InputA2, double ExpectedResult2)
        {
            uut.Add(InputA, InputB);

            Assert.That(uut.Accumulator,Is.EqualTo(ExpectedResult2));
            uut.Add(InputA2);
            Assert.That(uut.Accumulator,Is.EqualTo(ExpectedResult));
        }
        


    }
}