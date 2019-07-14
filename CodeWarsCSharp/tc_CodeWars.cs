using NUnit.Framework;

namespace ProjectCSharp.CodeWarsCSharp
{
    [TestFixture]
    public class WaterMelonTest
    {
        [Test]
        public void Test01()
        {
            Assert.AreEqual(Watermelon.Divide(4), true);
        }

        [Test]
        public void Test02()
        {
            Assert.AreEqual(Watermelon.Divide(2), false);
        }

        [Test]
        public void Test03()
        {
            Assert.AreEqual(Watermelon.Divide(5), false);
        }

        [Test]
        public void Test04()
        {
            Assert.AreEqual(Watermelon.Divide(88), true);
        }

        [Test]
        public void Test05()
        {
            Assert.AreEqual(Watermelon.Divide(100), true);
        }

        [Test]
        public void Test06()
        {
            Assert.AreEqual(Watermelon.Divide(67), false);
        }

        [Test]
        public void Test07()
        {
            Assert.AreEqual(Watermelon.Divide(90), true);
        }

        [Test]
        public void Test08()
        {
            Assert.AreEqual(Watermelon.Divide(10), true);
        }

        [Test]
        public void Test09()
        {
            Assert.AreEqual(Watermelon.Divide(99), false);
        }

        [Test]
        public void Test10()
        {
            Assert.AreEqual(Watermelon.Divide(32), true);
        }
    }
    [TestFixture]
    public class ReversedStringTest
    {
        [Test]
        public void World_test()
        {
            Assert.AreEqual("dlrow", ReversedString.Reversed("world"));
        }
    }
    
    [TestFixture]
    public class EvenOddTest
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual("Even", EvenOdd.EvenOrOdd(2));
            Assert.AreEqual("Odd", EvenOdd.EvenOrOdd(1));
            Assert.AreEqual("Even", EvenOdd.EvenOrOdd(0));
            Assert.AreEqual("Odd", EvenOdd.EvenOrOdd(7));
            Assert.AreEqual("Odd", EvenOdd.EvenOrOdd(-1));
        }
    }
    
    [TestFixture]
    public class DivisibleNumberTest
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(true, DivisibleNb.IsDivisible(12,4,3));
        }
        [Test]
        public void Test2() 
        {
            Assert.AreEqual(false, DivisibleNb.IsDivisible(3,3,4));
        }
        [Test]
        public void Test3()
        {
            Assert.AreEqual(false, DivisibleNb.IsDivisible(8,3,4));
        }
    }
    
    [TestFixture]
    public class DescendingOrderTest
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual(0, Descending.DescendingOrder(0));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(43, Descending.DescendingOrder(34));
        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual(95431, Descending.DescendingOrder(19345));
        }
    }
    
    [TestFixture]
    public class RemoveFirstCharTest
    {
        [Test]
        public void Test1()
        {
            StringAssert.AreEqualIgnoringCase("loquen", RemoveFirstChar.Remove_char("eloquent"));
            StringAssert.AreEqualIgnoringCase("ountr", RemoveFirstChar.Remove_char("country"));
            StringAssert.AreEqualIgnoringCase("erso", RemoveFirstChar.Remove_char("person"));
            StringAssert.AreEqualIgnoringCase("lac", RemoveFirstChar.Remove_char("place"));
            StringAssert.AreEqualIgnoringCase("", RemoveFirstChar.Remove_char("ok"));
        }
    }
    
    [TestFixture]
    public class AddBinaryTest
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("11", Binary.AddBinary(1, 2));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("1010", Binary.AddBinary(3, 7));
        }
    }
    
    [TestFixture]
    public class OppositeNumberTest
    {
        [Test]
        public void Test1()
        {   
            Assert.AreEqual(-1, OppositeNumber.Opposite(1));
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(50 , OppositeNumber.Opposite(-50));
        }
    }
}
