using NUnit.Framework;
using ProjectCSharp.Program_dir;

namespace ProjectCSharp.Tests_dir
{
    [TestFixture]
    public class TestMethodsSuite
    {
        [Test]
        public void F01_1()
        {
            Assert.AreEqual(0, MethodsSuite.F1(x: 0));
        }

        [Test]
        public void F01_2()
        {
            Assert.AreEqual(1, MethodsSuite.F1(x: 1));
        }

        [Test]
        public void F01_3()
        {
            Assert.AreEqual(4, MethodsSuite.F1(x: 2));
        }

        [Test]
        public void F01_4()
        {
            Assert.AreEqual(5, MethodsSuite.F1(x: 2, y: 1));
        }

        [Test]
        public void F01_5()
        {
            Assert.AreEqual(7, MethodsSuite.F1(x: 2, y: 3));
        }

        [Test]
        public void F01_6()
        {
            Assert.AreEqual(11.25, MethodsSuite.F1(x: 2.5, y: 5));
        }

        [Test]
        public void F02_1()
        {
            Assert.AreEqual("a", MethodsSuite.F2(x: "ala"));
        }

        [Test]
        public void F02_2()
        {
            Assert.AreEqual("1", MethodsSuite.F2(x: "1,2,3"));
        }

        [Test]
        public void F02_3()
        {
            Assert.AreEqual("BUUUUM", MethodsSuite.F2(x: ' '));
        }
        
        [Test]
        public void F02_4()
        {
            Assert.AreEqual("Not implemented yet", MethodsSuite.F2(x: "string"));
        }

        [Test]
        public void F03_1()
        {
            Assert.AreEqual("jeden", MethodsSuite.F3(x: 1));
        }

        [Test]
        public void F03_2()
        {
            Assert.AreEqual("dwa", MethodsSuite.F3(x: 2));
        }

        [Test]
        public void F03_3()
        {
            Assert.AreEqual("trzy", MethodsSuite.F3(x: 3));
        }

        [Test]
        public void F03_4()
        {
            Assert.AreEqual("other", MethodsSuite.F3(x: 100));
        }
        
        [Test]
        public void F03_5()
        {
            Assert.AreEqual("Not implemented yet", MethodsSuite.F3(x: 1001));
        }

        [Test]
        public void F04_1()
        {
            Assert.AreEqual("ala ma kota", MethodsSuite.F4(x: "ala"));
        }

        [Test]
        public void F04_2()
        {
            Assert.AreEqual("kot ma kota", MethodsSuite.F4(x: "kot"));
        }

        [Test]
        public void F04_3()
        {
            Assert.AreEqual("kot ma kota i psa", MethodsSuite.F4(x: "kot", y: "psa"));
        }

        [Test]
        public void F04_4()
        {
            Assert.AreEqual("kot ma kota i mysz", MethodsSuite.F4(x: "kot", y: "mysz"));
        }
        
        [Test]
        public void F04_5()
        {
            Assert.AreEqual("Not implemented yet", MethodsSuite.F4(x: "kot", y: "kot"));
        }

        [Test]
        public void F05_1()
        {
            Assert.AreEqual("", MethodsSuite.F5(x: 0));
        }
        
        [Test]
        public void F05_2()
        {
            Assert.AreEqual("0", MethodsSuite.F5(x: 1));
        }
        
        [Test]
        public void F05_3()
        {
            Assert.AreEqual("0,1", MethodsSuite.F5(x: 2));
        }
        
        [Test]
        public void F05_4()
        {
            Assert.AreEqual("0,1,2,3,4,5,6", MethodsSuite.F5(x: 7));
        }
        
        [Test]
        public void F05_5()
        {
            Assert.AreEqual("0,2,4,6", MethodsSuite.F5(x: 7, y: 2));
        }
        
        [Test]
        public void F05_6()
        {
            Assert.AreEqual("0,2,4,6,8,10,12,14,16", MethodsSuite.F5(x: 17, y: 2));
        }
        
        [Test]
        public void F05_7()
        {
            Assert.AreEqual("0,5,10,15", MethodsSuite.F5(x: 17, y: 5));
        }
        
        [Test]
        public void F05_8()
        {
            Assert.AreEqual("Not implemented yet", MethodsSuite.F5(x: 25, y: 10));
        }
        
        [Test]
        public void F05_9()
        {
            Assert.AreEqual("Not implemented yet", MethodsSuite.F5(x: 15));
        }
        
        [Test]
        public void F06_1()
        {
            Assert.AreEqual("*", MethodsSuite.F6(x: 1, y: "*"));
        }
        
        [Test]
        public void F06_2()
        {
            Assert.AreEqual("*******", MethodsSuite.F6(x: 7, y: "*"));
        }
        
        [Test]
        public void F06_3()
        {
            Assert.AreEqual("Not implemented yet", MethodsSuite.F6(x: 10, y: "*"));
        }
        
        [Test]
        public void F07_1()
        {
            Assert.AreEqual("cyfra", MethodsSuite.F7(x: 1));
        }
        
        [Test]
        public void F07_2()
        {
            Assert.AreEqual("liczba", MethodsSuite.F7(x: 11111));
        }
        
        [Test]
        public void F07_3()
        {
            Assert.AreEqual("liczba ze znakiem", MethodsSuite.F7(x: -11111));
        }
        
        [Test]
        public void F07_4()
        {
            Assert.AreEqual("slowo", MethodsSuite.F7(x: "ala"));
        }
        
        [Test]
        public void F07_5()
        {
            Assert.AreEqual("zdanie", MethodsSuite.F7(x: "Ala ma kota"));
        }
        
        [Test]
        public void F07_6()
        {
            Assert.AreEqual("tag poczatkowy", MethodsSuite.F7(x: "<taaag>"));
        }
        
        [Test]
        public void F07_7()
        {
            Assert.AreEqual("tag koncowy", MethodsSuite.F7(x: "</taaag>"));
        }
        
        [Test]
        public void F08_1()
        {
            Assert.AreEqual(true, MethodsSuite.F8(x: "kot", y: "ala ma kota"));
        }
        
        [Test]
        public void F08_2()
        {
            Assert.AreEqual(false, MethodsSuite.F8(x: "pies", y: "ala ma kota"));
        }
        
        [Test]
        public void F09_1()
        {
            Assert.AreEqual("dodatnie", MethodsSuite.F9(x: 1, y: 2));
        }
        
        [Test]
        public void F09_2()
        {
            Assert.AreEqual("ujemne", MethodsSuite.F9(x: -1, y: -2));
        }
        
        [Test]
        public void F09_3()
        {
            Assert.AreEqual("roznych znakow", MethodsSuite.F9(x: -1, y: 1));
        }
        
        [Test]
        public void F09_4()
        {
            Assert.AreEqual("jest zero", MethodsSuite.F9(x: -1, y: 0));
        }
        
        [Test]
        public void F09_5()
        {
            Assert.AreEqual("Not implemented yet", MethodsSuite.F9(x: 1, y: 0));
        }
        
        [Test]
        public void F10_1()
        {
            Assert.AreEqual("rowne", MethodsSuite.F10(x: 1, y: 1));
        }
        
        [Test]
        public void F10_2()
        {
            Assert.AreEqual("rozne", MethodsSuite.F10(x: 1, y: 2));
        }
    }
}