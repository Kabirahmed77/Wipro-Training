namespace Demo.Tests
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
            Demo demo = new Demo();
            Assert.AreEqual("Welcome to Unit Testing...", demo.SayHello());
        }
        [Test]
        public void Test2_Negative()
        {
            Demo demo = new Demo();
            Assert.AreNotEqual("Hello World", demo.SayHello());
        }
    }
}
