using System;
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

        //[TestCase(-6,-2,-4)]
        //[TestCase(5, 2, 3)]
        //[TestCase(-1, -4, 3)]
        //public void Add_DoAddAWithB_IsExpectedResult(double ExpectedResult, double InputA, double InputB)
        //{
        //    double value = uut.Add(InputA, InputB);

        //    Assert.That(value,Is.EqualTo(ExpectedResult));
        //}

        //[TestCase(10,5,3,2)]
        //[TestCase(22,-2,20,4)]
        //[TestCase(-18,-2,-20,4)]
        //[TestCase(-26,-2,-20,-4)]
        //public void Add_MethodOverloadDoAddAWithAccumulator_IsExpectedResult(double ExpectedResult, double InputA,
        //    double InputB, double InputA2)
        //{
        //    uut.Add(InputA, InputB);
        //    double value = uut.Add(InputA2);

        //    Assert.That(value, Is.EqualTo(ExpectedResult));
        //}
        [TestCase(5, 2, 3, 5, 10)]
        [TestCase(5, 2, 3, -5, 0)]
        [TestCase(-1, 2, -3, -5, -6)]
        [TestCase(5.5, 2.5, 3, 5.5, 11)]
        public void Add_DoAddMethod_IsExpectedResult(double ExpectedResult, double InputA,
            double InputB, double InputA2, double ExpectedResult2)
        {
            uut.Add(InputA, InputB);

            Assert.That(uut.Accumulator, Is.EqualTo(ExpectedResult));
            uut.Add(InputA2);
            Assert.That(uut.Accumulator, Is.EqualTo(ExpectedResult2));
        }

        [TestCase(5,6)]
        [TestCase(-10,13)]
        [TestCase(-20,-40)]
        [TestCase(20.5,10.6)]
        public void Add_TestAccumulatorAndReturnValue_IsEqual(double InputA, double InputB)
        {
            double value = uut.Add(InputA, InputB);
            Assert.That(uut.Accumulator, Is.EqualTo(value));
        }



        [TestCase(-1, 2, 3, 5, -6)]
        [TestCase(-1, 2, 3, -5, 4)]
        [TestCase(5, 2, -3, -5, 10)]
        [TestCase(-0.5, 2.5, 3, 5.5, -6)]
        public void Subtract_DoSubtractMethod_IsExpectedResult(double ExpectedResult, double InputA,
            double InputB, double InputA2, double ExpectedResult2)
        {
            uut.Subtract(InputA, InputB);

            Assert.That(uut.Accumulator, Is.EqualTo(ExpectedResult));
            uut.Subtract(InputA2);
            Assert.That(uut.Accumulator, Is.EqualTo(ExpectedResult2));
        }

        [TestCase(5, 6)]
        [TestCase(-10, 13)]
        [TestCase(-20, -40)]
        [TestCase(20.5, 10.6)]
        public void Subtract_TestAccumulatorAndReturnValue_IsEqual(double InputA, double InputB)
        {
            double value = uut.Subtract(InputA, InputB);
            Assert.That(uut.Accumulator, Is.EqualTo(value));
        }


        [TestCase(6, 2, 3, 5, 30)]
        [TestCase(6, 2, 3, -5, -30)]
        [TestCase(-6, 2, -3, -5, 30)]
        [TestCase(7.5, 2.5, 3, 5.5, 41.25)]
        public void Multiply_DoMultiplytMethod_IsExpectedResult(double ExpectedResult, double InputA,
            double InputB, double InputA2, double ExpectedResult2)
        {
            uut.Multiply(InputA, InputB);

            Assert.That(uut.Accumulator, Is.EqualTo(ExpectedResult));
            uut.MultiPly(InputA2);
            Assert.That(uut.Accumulator, Is.EqualTo(ExpectedResult2));
        }

        [TestCase(5, 6)]
        [TestCase(-10, 13)]
        [TestCase(-20, -40)]
        [TestCase(20.5, 10.6)]
        public void Multiply_TestAccumulatorAndReturnValue_IsEqual(double InputA, double InputB)
        {
            double value = uut.Multiply(InputA, InputB);
            Assert.That(uut.Accumulator, Is.EqualTo(value));
        }
       
       
        [TestCase(10, 50, 5, 5, 2)]
        [TestCase(50, 250, 5, 3.2, 15.625)]
        [TestCase(-50, 250, -5, -5, 10)]
        public void Division_DoDivisionMethod_IsExpectedResult(double ExpectedResult, double InputA,
            double InputB, double InputA2, double ExpectedResult2)
        {
            uut.Division(InputA, InputB);

            Assert.That(uut.Accumulator, Is.EqualTo(ExpectedResult));
            uut.Division(InputA2);
            Assert.That(uut.Accumulator, Is.EqualTo(ExpectedResult2));
        }

        [TestCase(5, 6)]
        [TestCase(-10, 13)]
        [TestCase(-20, -40)]
        [TestCase(20.5, 10.6)]
        public void Division_TestAccumulatorAndReturnValue_IsEqual(double InputA, double InputB)
        {
            double value = uut.Division(InputA, InputB);
            Assert.That(uut.Accumulator, Is.EqualTo(value));
        }

        [TestCase(1, 1, 2, 2, 1)]
        [TestCase(8, 2, 3, -2, 0.015625)]
        [TestCase(4, -2, 2, 2, 16)]
        public void Power_DoPowerMethod_IsExpectedResult(double ExpectedResult, double InputA,
            double InputB, double InputA2, double ExpectedResult2)
        {
            uut.Power(InputA, InputB);

            Assert.That(uut.Accumulator, Is.EqualTo(ExpectedResult));
            uut.Power(InputA2);
            Assert.That(uut.Accumulator, Is.EqualTo(ExpectedResult2));
        }

        [TestCase(5, 6)]
        [TestCase(-10, 13)]
        [TestCase(-20, -40)]
        [TestCase(20.5, 10.6)]
        public void Power_TestAccumulatorAndReturnValue_IsEqual(double InputA, double InputB)
        {
            double value = uut.Power(InputA, InputB);
            Assert.That(uut.Accumulator, Is.EqualTo(value));
        }

        [TestCase(0,5)]
        [TestCase(5,0)]
        public void Exception_TestDivisionThrowsDivideBy0Exception_IsThrown(double InputA, double InputB)
        {
            //uut.Division(InputA, InputB);
            Assert.Throws<DivideByZeroException>((() => uut.Division(InputA,InputB)));
        }

        [TestCase(10, 50, 0)]
        public void Exception_TestDivisionOverloadThrowsDivideBy0Exception_IsThrown(double InputA, double InputB, double InputA2)
        {
            uut.Division(InputA, InputB);
            Assert.Throws<DivideByZeroException>((() => uut.Division(InputA2)));
        }

        [TestCase(2,3)]
        public void Clear_SetAccumulatorTo0_IsExpectedToBe0(double InputA, double InputB)
        {
            uut.Add(InputA, InputB);
            uut.Clear();

            Assert.That(uut.Accumulator,Is.EqualTo(0));
        }

        //[TestCase(8,2,3)]
        //[TestCase(-8, -2, 3)]
        //[TestCase(-0.125, -2, -3)]
        //public void Power_MethodDoPowerAwithB_IsExpectedResult(double ExpectedResult, double InputA, double InputB)
        //{
        //    double value = uut.Power(InputA, InputB);

        //    Assert.That(value, Is.EqualTo(ExpectedResult));
        //}
        //[TestCase(5, 10, 2)]
        //[TestCase(-10, 50, -5)]
        //[TestCase(10, -50, -5)]
        //public void Division_MethodDoDivideAwithB_IsExpectedResult(double ExpectedResult, double InputA, double InputB)
        //{
        //    double value = uut.Division(InputA, InputB);

        //    Assert.That(value, Is.EqualTo(ExpectedResult));
        //}

        //[TestCase(5,50,5,2)]
        //[TestCase(15.625,250,5,3.2)]
        //public void Division_MethodOverloadDoDivideAWithAccumulator_IsExpectedResult(double ExpectedResult, double InputA, double InputB, double InputA2)
        //{
        //    uut.Division(InputA,InputB);
        //    double value= uut.Division(InputA2);

        //    Assert.That(value, Is.EqualTo(ExpectedResult));
        //}
        
        


    }
}