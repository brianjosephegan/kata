using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Kata.Tests
{
    [TestFixture]
    public class MultiplesFinderTests
    {
        private readonly MultiplesFinder multiplesFinder = new MultiplesFinder();

        [Test]
        public void Test()
        {
            Assert.AreEqual(new List<int> { 5, 10, 15, 20, 25 }, multiplesFinder.Find(5, 25));
            Assert.AreEqual(new List<int> { 1, 2 }, multiplesFinder.Find(1, 2));
        }
    }
}
