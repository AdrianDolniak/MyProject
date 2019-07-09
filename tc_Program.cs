using NUnit.Framework;
using Program;

namespace Tests
{
    public class TestSuite1
    {
        [Test]
        public void F01_1()
        {
            Assert.AreEqual(0, Math.F1(x: 0));
        }

        [Test]
        public void F01_2()
        {
            Assert.AreEqual(1, Math.F1(x: 1));
        }

        [Test]
        public void F01_3()
        {
            Assert.AreEqual(4, Math.F1(x: 2));
        }

        [Test]
        public void F01_4()
        {
            Assert.AreEqual(5, Math.F1(x: 2, y: 1));
        }

        [Test]
        public void F01_5()
        {
            Assert.AreEqual(7, Math.F1(x: 2, y: 3));
        }

        [Test]
        public void F02_1()
        {
            Assert.True(true);
        }
    }
}