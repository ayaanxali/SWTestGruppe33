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
            //calculator = new FakeCalculator();
        }

        [Test]
        public void Test_Add_Method()
        {
            double value = uut.Add(2, 4);

            Assert.That(value,Is.EqualTo(6));
        }

        [TestCase(5, 1)]
        public void Add_DoAddAWithB_1IsExpectedResult(int var, double var2)
        {
            double value = uut.Add(2, 3);

            Assert.That(value, Is.EqualTo(var));
        }
        [TestCase(10,4,6)]
        public void Subtract_MethodDoSubstractAWithB_IsExpectedResult(double varA,double varB,double expectedResult)
        {
            double value = uut.Subtract(varA, varB);

            //Assert
            Assert.That(value, Is.EqualTo(expectedResult));
        }
        [Test]
        public void Test_Multiply_Method()
        {
            double value = uut.Multiply(10, 4);

            Assert.That(value, Is.EqualTo(40));
        }
        [Test]
        public void Test_Power_Method()
        {
            double value = uut.Power(2, 3);

            Assert.That(value, Is.EqualTo(8));
        }

    }
}