using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using static Kata.BinaryTreeLevelSorter;

namespace Kata.Tests
{
    [TestFixture]
    public sealed class BinaryTreeLevelSorterTests
    {
        private readonly BinaryTreeLevelSorter binaryTreeLevelSorter = new BinaryTreeLevelSorter();

        [Test]
        public void NullTest()
        {
            Assert.AreEqual(
                new List<int>(),
                binaryTreeLevelSorter.Sort(null));
        }

        [Test]
        public void BasicTest()
        {
            Assert.AreEqual(
                new List<int>() { 1, 2, 3, 4, 5, 6 },
                binaryTreeLevelSorter.Sort(new Node(new Node(null, new Node(null, null, 4), 2), new Node(new Node(null, null, 5), new Node(null, null, 6), 3), 1)));
        }
    }
}
