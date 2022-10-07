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
        [Test]
        public void AddNewTest3()
        {
            Console.WriteLine("My 2 branch-conflicts");
        }
        [Test]
        public void AddNewTest4()
        {
            Console.WriteLine("My 3 branch- fetching and merging");
        }
        [Test]
        public void AddNewTest4a()
        {
            Console.WriteLine("My 4 branch- branching");
        }
        [Test]
        public void AddNewTest5()
        {
            Console.WriteLine("My 5 branch- merging- diverged branches");
        }
        [Test]
        public void AddNewTest6()
        {
            Console.WriteLine("My 6 branch- rebasing");
        }
        [Test]
        public void AddNewTest7()
        {
            Console.WriteLine("My 7 branch- add a bug - amend");
            Console.WriteLine("bug fix");
        }
        [Test]
        public void AddNewTest8()
        {
            Console.WriteLine("My 8 branch- resolve conflicts rebasing");
        }
    }

}