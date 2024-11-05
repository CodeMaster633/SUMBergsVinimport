

namespace Test
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
            Assert.Pass();
        }
        public void Test2()
        {
            Assert.AreEqual(1, 2);
        }
    }
}