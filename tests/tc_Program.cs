using NUnit.Framework;
using ProjectCSharp.program;

namespace ProjectCSharp.tests
{
    [TestFixture]
    public class TestMethodsSuite
    {
        [Test]
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(2, 4)]
        public void Test_Power(double input, double expectedResult)
        {
            Assert.AreEqual(expectedResult, MethodsSuite.Power(x: input));
        }
        [Test]
        [TestCase(2, 1, 5)]
        [TestCase(2, 3, 7)]
        [TestCase(2.5, 5, 11.25)]
        public void Test_Power(double inputX, double inputY, double expectedResult)
        {
            Assert.AreEqual(expectedResult, MethodsSuite.Power(x: inputX, y: inputY));
        }

        [Test]
        [TestCase("ala", "a")]
        [TestCase("1,2,3", "1")]
        [TestCase(" ", "BUUUUM")]
        public void Test_FirstCharFromString(string input, string expectedResult)
        {
            Assert.AreEqual(expectedResult, MethodsSuite.FirstCharFromString(x: input));
        }

        [Test]
        [TestCase(1, "jeden")]
        [TestCase(2, "dwa")]
        [TestCase(3, "trzy")]
        [TestCase(100, "other")]
        public void Test_IntToString(int input, string expectedResult)
        {
            Assert.AreEqual(expectedResult, MethodsSuite.IntToString(x: input));
        }
        
        [Test]
        [TestCase(1001)]
        public void Test_IntToString(int input)
        {
            Assert.Throws<System.ArgumentOutOfRangeException>(() => MethodsSuite.IntToString(x: input));
        }

        [Test]
        [TestCase("ala", "ala ma kota")]
        [TestCase("kot", "kot ma kota")]
        public void Test_StringInString(string input, string expectedResult)
        {
            Assert.AreEqual(expectedResult, MethodsSuite.StringInString(x: input));
        }

        [Test]
        [TestCase("kot", "psa", "kot ma kota i psa")]
        [TestCase("kot", "mysz", "kot ma kota i mysz")]
        public void Test_StringInString(string inputX, string inputY, string expectedResult)
        {
            Assert.AreEqual(expectedResult, MethodsSuite.StringInString(x: inputX, y: inputY));
        }

        [Test]
        [TestCase(0, "")]
        [TestCase(1, "0")]
        [TestCase(2, "0,1")]
        [TestCase(7, "0,1,2,3,4,5,6")]
        public void Test_Range(int input, string expectedResult)
        {
            Assert.AreEqual(expectedResult, MethodsSuite.Range(x: input));
        }
        
        [Test]
        [TestCase(7, 2, "0,2,4,6")]
        [TestCase(17, 2, "0,2,4,6,8,10,12,14,16")]
        [TestCase(17, 5, "0,5,10,15")]
        public void Test_Range(int inputX, int inputY, string expectedResult)
        {
            Assert.AreEqual(expectedResult, MethodsSuite.Range(x: inputX, y: inputY));
        }
        
        [Test]
        [TestCase(1, "*", "*")]
        [TestCase(7, "*", "*******")]
        public void Test_StarConcat(int inputX, string inputY, string expectedResult)
        {
            Assert.AreEqual(expectedResult, MethodsSuite.StarConcat(x: inputX, y: inputY));
        }
        
        [Test]
        [TestCase(1, "cyfra")]
        [TestCase(11111, "liczba")]
        [TestCase(-11111, "liczba ze znakiem")]
        public void Test_Dictionary(int input, string expectedResult)
        {
            Assert.AreEqual(expectedResult, MethodsSuite.Dictionary(x: input));
        }
        
        [Test]
        [TestCase("ala", "slowo")]
        [TestCase("Ala ma kota", "zdanie")]
        [TestCase("<taaag>", "tag poczatkowy")]
        [TestCase("</taaag>", "tag koncowy")]
        public void Test_Dictionary(string input, string expectedResult)
        {
            Assert.AreEqual(expectedResult, MethodsSuite.Dictionary(x: input));
        }
        
        [Test]
        [TestCase("kot", "ala ma kota", true)]
        [TestCase("pies", "ala ma kota", false)]
        public void Test_ContainsOrNot(string inputX, string inputY, bool expectedResult)
        {
            Assert.AreEqual(expectedResult, MethodsSuite.ContainsOrNot(x: inputX, y: inputY));
        }
        
        [Test]
        [TestCase(1, 2, "dodatnie")]
        [TestCase(-1, -2, "ujemne")]
        [TestCase(-1, 1, "roznych znakow")]
        [TestCase(-1, 0, "jest zero")]
        public void Test_WhatSignOfThat(int inputX, int inputY, string expectedResult)
        {
            Assert.AreEqual(expectedResult, MethodsSuite.WhatSignOfThat(x: inputX, y: inputY));
        }
        
        [Test]
        [TestCase(1, 1, "rowne")]
        [TestCase(1, 2, "rozne")]
        public void Test_EqualOrNot(int inputX, int inputY, string expectedResult)
        {
            Assert.AreEqual(expectedResult, MethodsSuite.EqualOrNot(x: inputX, y: inputY));
        }
    }
}