using NUnit.Framework;
using ProjectCSharp.program;

namespace ProjectCSharp.tests
{
    [TestFixture]
    public class CalculatorTest
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
        public void TestCalculatorModulo()
        {
            Assert.AreEqual(0, Calculator.Modulo(6, 6));
            Assert.AreEqual(0, Calculator.Modulo(8, 4));
            Assert.AreEqual(0, Calculator.Modulo(100, 10));
        }
    }
}