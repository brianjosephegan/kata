using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Kata.Tests
{
    [TestFixture]
    public class HighestScoringWordFinderTests
    {
        private HighestScoringWordFinder _highestScoringWordFinder = new HighestScoringWordFinder();

        [TestCase("man i need a taxi up to ubud", "taxi")]
        [TestCase("what time are we climbing up to the volcano", "volcano")]
        [TestCase("take me to semynak", "semynak")]
        [TestCase("aa b", "aa")]
        [TestCase("b aa", "b")]
        [TestCase("bb d", "bb")]
        [TestCase("d bb", "d")]
        [TestCase("aaa b", "aaa")]
        public void Test(string input, string expectedWord)
        {
            var actualWord = _highestScoringWordFinder.Find(input);

            Assert.AreEqual(expectedWord, actualWord);
        }
    }
}
