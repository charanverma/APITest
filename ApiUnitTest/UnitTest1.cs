using NUnit.Framework;

namespace ApiUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.IsTrue(true);


        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(2,2);


        }

        [Test]
        public void Test3()
        {
            Assert.AreEqual("Charan", "Charan");


        }
    }
}