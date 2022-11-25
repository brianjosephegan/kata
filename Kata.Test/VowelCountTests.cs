using FluentAssertions;
using Xunit;

namespace Kata.Test
{
    public class VowelCountTests
    {
        [Theory]
        [InlineData("", 0)]
        [InlineData("a", 1)]
        [InlineData("u2978u", 2)]
        [InlineData("bb", 0)]
        [InlineData("aeiou", 5)]
        public void Test(string input, int expected)
        {
            var result = VowelCount.GetVowelCount(input);

            result.Should().Be(expected);
        }
    }
}