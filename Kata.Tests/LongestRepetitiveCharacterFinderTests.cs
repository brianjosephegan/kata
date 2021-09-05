using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Kata.Tests
{
    [TestFixture]
    public class LongestRepetitiveCharacterFinderTests
    {
        private readonly LongestRepetitiveCharacterFinder longestRepetitiveCharacterFinder = new LongestRepetitiveCharacterFinder();

        [Test]
        public void LongestAtTheBeginningTest()
        {
            Assert.AreEqual(new Tuple<char?, int>('a', 4), longestRepetitiveCharacterFinder.Find("aaaabb"));
            Assert.AreEqual(new Tuple<char?, int>('b', 5), longestRepetitiveCharacterFinder.Find("abbbbb"));
        }

        [Test]
        public void LongestAtTheEndTest()
        {
            Assert.AreEqual(new Tuple<char?, int>('a', 4), longestRepetitiveCharacterFinder.Find("bbbaaabaaaa"));
        }

        [Test]
        public void LongestInTheMiddleTest()
        {
            Assert.AreEqual(new Tuple<char?, int>('u', 3), longestRepetitiveCharacterFinder.Find("cbdeuuu900"));
        }

        [Test]
        public void MultipleLongestTest()
        {
            Assert.AreEqual(new Tuple<char?, int>('a', 2), longestRepetitiveCharacterFinder.Find("aabb"));
            Assert.AreEqual(new Tuple<char?, int>('b', 1), longestRepetitiveCharacterFinder.Find("ba"));
        }

        [Test]
        public void EmptyStringTest()
        {
            Assert.AreEqual(new Tuple<char?, int>(null, 0), longestRepetitiveCharacterFinder.Find(""));
        }
    }
}
