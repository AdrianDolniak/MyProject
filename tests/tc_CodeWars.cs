using NUnit.Framework;
using ProjectCSharp.program;

namespace ProjectCSharp.tests
{
    [TestFixture]
    public class TestWaterMelon
    {
        [Test]
        [TestCase(4, true)]
        [TestCase(2, false)]
        [TestCase(5, false)]
        [TestCase(88, true)]
        [TestCase(100,true)]
        [TestCase(67, false)]
        [TestCase(90, true)]
        [TestCase(10,true)]
        [TestCase(99, false)]
        [TestCase(32, true)]
        public void Test_WaterMelon(int input, bool expectedResult)
        {
            Assert.AreEqual(expectedResult, Watermelon.Divide(input));
        }
    }

    [TestFixture]
    public class TestReversedString
    {
        [Test]
        [TestCase("world", "dlrow")]
        [TestCase("Adrian", "nairdA")]
        public void Test_ReversedString(string input, string expectedResult)
        {
            Assert.AreEqual(expectedResult, ReversedString.Reversed(input));
        }
    }

    [TestFixture]
    public class TestEvenOdd
    {
        [Test]
        [TestCase(2, "Even")]
        [TestCase(1, "Odd")]
        [TestCase(0, "Even")]
        [TestCase(7, "Odd")]
        [TestCase(-1, "Odd")]
        public void Test_EvenOdd(int input, string expectedResult)
        {
            Assert.AreEqual(expectedResult, EvenOdd.EvenOrOdd(input));
        }
    }

    [TestFixture]
    public class TestDivisibleNumber
    {
        [Test]
        [TestCase(12, 4, 3, true)]
        [TestCase(3, 3, 4, false)]
        [TestCase(8, 3, 4, false)]
        public void Test_DivisibleNumber(int inputX, int inputY, int inputZ, bool expectedResult)
        {
            Assert.AreEqual(expectedResult, DivisibleNb.IsDivisible(inputX, inputY, inputZ));
        }
    }

    [TestFixture]
    public class TestDescendingOrder
    {
        [Test]
        [TestCase(0, 0)]
        [TestCase(34, 43)]
        [TestCase(19345, 95431)]
        public void Test_DescendingOrder(int input, int expectedResult)
        {
            Assert.AreEqual(expectedResult, Descending.DescendingOrder(input));
        }
    }

    [TestFixture]
    public class TestRemoveFirstAndLastChar
    {
        [Test]
        [TestCase("eloquent", "loquen")]
        [TestCase("country", "ountr")]
        [TestCase("person", "erso")]
        [TestCase("place", "lac")]
        [TestCase("ok", "")]
        public void Test_RemoveFirstAndLastChar(string input, string expectedResult)
        {
            Assert.AreEqual(expectedResult, RemoveFirstAndLastChar.Remove_char(input));
        }
    }

    [TestFixture]
    public class TestAddBinary
    {
        [Test]
        [TestCase(1, 2, "11")]
        [TestCase(3, 7, "1010")]
        public void Test_AddBinary(int inputX, int inputY, string expectedResult)
        {
            Assert.AreEqual(expectedResult, Binary.AddBinary(inputX, inputY));
        }
    }

    [TestFixture]
    public class TestOppositeNumber
    {
        [Test]
        [TestCase(1, -1)]
        [TestCase(-50, 50)]
        public void Test_OppositeNumber(int input, int expectedResult)
        {
            Assert.AreEqual(expectedResult, OppositeNumber.Opposite(input));
        }
    }

    [TestFixture]
    public class TestSumOfTwoLowestPositiveIntegers
    {
        [Test]
        [TestCase("19, 5, 42, 2, 77", 7)]
        [TestCase("10, 343445353, 3453445, 3453545353453",3453455)]
        public void Test_SumOfTwoLowestPositiveIntegers(string input, int expectedResult)
        {
            Assert.AreEqual(expectedResult, SumOfTwoLowestPositiveIntegers.Sum(input));
        }
    }

    [TestFixture]
    public class TestConvertAStringToAnArray
    {
        [Test]
        [TestCase("Robin Singh", new string[] {"Robin", "Singh"})]
        [TestCase("I love arrays they are my favorite", new string[] {"I", "love", "arrays", "they", "are", "my", "favorite"})]
        public void Test_ConvertAStringToAnArray(string input, string[] expectedResult)
        {
            Assert.AreEqual(expectedResult, ConvertAStringToAnArray.ConvertToString(input));
        }
    }

    [TestFixture]
    public class TestSumWithoutHighestAndLowestNumber
    {
        [Test]
        [TestCase(new[] { 6, 2, 1, 8, 10}, 16)]
        [TestCase(new[] { 6 }, 0)]
        [TestCase(null, 0)]
        public void Test_SumWithoutHighestAndLowestNumber(int[] input, int expectedResult)
        {
            Assert.AreEqual(expectedResult, SumWithoutHighestAndLowestNumber.Sum(input));
        }
    }

    [TestFixture]
    public class TestShortestWord
    {
        [Test]
        [TestCase("bitcoin take over the world maybe who knows perhaps", 3)]
        [TestCase("turns out random test cases are easier than writing out basic ones", 3)]
        [TestCase("Quisque semper justo at risus", 2)]
        public void Test_ShortestWord(string input, int expectedResult)
        {
            Assert.AreEqual(expectedResult, ShortestWord.Short(input));
        }
    }

    [TestFixture]
    public class TestIsIsogram
    {
        [Test]
        //[TestCase("Dermatoglyphics", true)]
        //[TestCase("isogram", true)]
        [TestCase("isIsogram", false)]
        [TestCase("aba", false)]
        [TestCase("moOse", false)]
        //[TestCase("thumbscrewjapingly", true)]
        [TestCase("", true)]
        public void Test_IsIsogram(string input, bool expectedResult)
        {
            Assert.AreEqual(expectedResult, IsIsogram.Isogram(input));
        }
    }
}
