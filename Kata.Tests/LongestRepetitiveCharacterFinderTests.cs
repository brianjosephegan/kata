using FluentAssertions;
using System;
using Xunit;

namespace Kata.Tests
{
    public class LongestRepetitiveCharacterFinderTests
    {
        private readonly LongestRepetitiveCharacterFinder _longestRepetitiveCharacterFinder = new LongestRepetitiveCharacterFinder();

        [Fact]
        public void LongestAtTheBeginningTest()
        {
            var expected = new Tuple<char?, int>('a', 4);

            var result = _longestRepetitiveCharacterFinder.Find("aaaabb");

            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void LongestAtTheEndTest()
        {
            var expected = new Tuple<char?, int>('a', 4);

            var result = _longestRepetitiveCharacterFinder.Find("bbbaaabaaaa");

            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void LongestInTheMiddleTest()
        {
            var expected = new Tuple<char?, int>('u', 3);

            var result = _longestRepetitiveCharacterFinder.Find("cbdeuuu900");

            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void MultipleLongestTest()
        {
            var expected = new Tuple<char?, int>('a', 2);

            var result = _longestRepetitiveCharacterFinder.Find("aabb");

            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void EmptyStringTest()
        {
            var expected = new Tuple<char?, int>(null, 0);

            var result = _longestRepetitiveCharacterFinder.Find(string.Empty);

            result.Should().BeEquivalentTo(expected);
        }
    }
}
