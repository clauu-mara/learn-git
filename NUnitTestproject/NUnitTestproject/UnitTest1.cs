namespace NUnitTestproject
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
        [Test]
        public void AddNewTest()
        {
            Console.WriteLine("My first branch");
        }
        [Test]
        public void AddNewTest1()
        {
            Console.WriteLine("My first branch-another commit");
        }
    }
}