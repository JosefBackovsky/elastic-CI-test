using System.Threading;
using NUnit.Framework;

namespace test
{
    [Category("CategoryA")]
    [TestFixture]
    public class TestsA
    {
        const int Delay = 1000;

        [Test]
        public void Test1()
        {
            Thread.Sleep(Delay);
            Assert.AreEqual(1,1);
        }

        [Test]
        public void Test2()
        {
            Thread.Sleep(Delay);
            Assert.AreEqual(1, 1);
        }

        [Test]
        public void Test3()
        {
            Thread.Sleep(Delay);
            Assert.AreEqual(1, 1);
        }

        [Test]
        public void Test4()
        {
            Thread.Sleep(Delay);
            Assert.AreEqual(1, 1);
        }

        [Test]
        public void Test5()
        {
            Thread.Sleep(Delay);
            Assert.AreEqual(1, 1);
        }
        [Test]

        public void Test6()
        {
            Thread.Sleep(Delay);
            Assert.AreEqual(1, 1);
        }

        [Test]
        public void Test7()
        {
            Thread.Sleep(Delay);
            Assert.AreEqual(1, 1);
        }

        [Test]
        public void Test8()
        {
            Thread.Sleep(Delay);
            Assert.AreEqual(1, 1);
        }

        [Test]
        public void Test9()
        {
            Thread.Sleep(Delay);
            Assert.AreEqual(1, 1);
        }

        [Test]
        public void Test10()
        {
            Thread.Sleep(Delay);
            Assert.AreEqual(1, 1);
        }
    }
}
