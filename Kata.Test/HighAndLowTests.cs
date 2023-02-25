using FluentAssertions;
using Xunit;

namespace Kata.Test
{
    public class HighAndLowTests
    {
        [Theory]
        [InlineData("1 2 3", "3 1")]
        [InlineData("8 3 -5 42 -1 0 0 -9 4 7 4 -4", "42 -9")]
        public void Test(string input, string expected)
        {
            HighAndLow.Get(input).Should().Be(expected);
        }
    }
}
