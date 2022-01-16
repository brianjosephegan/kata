using FluentAssertions;
using Xunit;

namespace Kata.Tests
{
    public class AsciiTotalTests
    {
        [Theory]
        [InlineData("", 0)]
        [InlineData("a", 97)]
        [InlineData("b", 98)]
        [InlineData("c", 99)]
        [InlineData("aaa", 291)]
        [InlineData("Mary Had A Little Lamb", 1873)]
        public void Test(string input, int expected)
        {
            var result = AsciiTotal.SumCharacters(input);

            result.Should().Be(expected);
        }
    }
}
