using NUnit.Framework;
using ProjectCSharp.program;

namespace ProjectCSharp.tests
{
    [TestFixture]
    public class TestCalculator
    {
        [Test]
        public void TestCalculatorAdding()
        {
            Assert.AreEqual(30, Calculator.Adding(10, 20));         
        }
        [Test]
        public void TestCalculatorSubtract()
        {
            Assert.AreEqual(5, Calculator.Subtract(15, 10));
        }
        [Test]
        public void TestCalculatorMultiply()
        {
            Assert.AreEqual(35, Calculator.Multiply(5, 7));         
        }
        [Test]
        public void TestCalculatorDivide()
        {
            Assert.AreEqual(4, Calculator.Divide(24, 6));        
        }

        [Test]
        public void TestCalculatorPower()
        {
            Assert.AreEqual(expected:27, Calculator.Power(3, 3));
        }
    }
}