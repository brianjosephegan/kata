using FluentAssertions;
using System;
using Xunit;

namespace Kata.Test
{
    public class LongestRepetitiveCharacterTests
    {
        [Fact]
        public void LongestAtTheBeginningTest()
        {
            var expected = new Tuple<char?, int>('a', 4);

            var result = LongestRepetitiveCharacter.Find("aaaabb");

            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void LongestAtTheEndTest()
        {
            var expected = new Tuple<char?, int>('a', 4);

            var result = LongestRepetitiveCharacter.Find("bbbaaabaaaa");

            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void LongestInTheMiddleTest()
        {
            var expected = new Tuple<char?, int>('u', 3);

            var result = LongestRepetitiveCharacter.Find("cbdeuuu900");

            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void MultipleLongestTest()
        {
            var expected = new Tuple<char?, int>('a', 2);

            var result = LongestRepetitiveCharacter.Find("aabb");

            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void EmptyStringTest()
        {
            var expected = new Tuple<char?, int>(null, 0);

            var result = LongestRepetitiveCharacter.Find(string.Empty);

            result.Should().BeEquivalentTo(expected);
        }
    }
}
