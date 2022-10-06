using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestproject
{
    internal class MySecondClass
    {
        int _isATest = 5;

        [Test]
        public void Test1()
        {
            Assert.AreEqual(5, _isATest);
        }
        [Test]
        public void Test6()
        {
            Console.WriteLine("rebasing");
        }
        [Test]
        public void Test6r()
        {
            Console.WriteLine("rebasing ");
        }

    }
}
