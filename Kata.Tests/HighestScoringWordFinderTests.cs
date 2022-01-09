using FluentAssertions;
using Xunit;

namespace Kata.Tests
{
    public class HighestScoringWordFinderTests
    {
        private readonly HighestScoringWordFinder _highestScoringWordFinder = new HighestScoringWordFinder();

        [Theory]
        [InlineData("man i need a taxi up to ubud", "taxi")]
        [InlineData("what time are we climbing up to the volcano", "volcano")]
        [InlineData("take me to semynak", "semynak")]
        [InlineData("aa b", "aa")]
        [InlineData("b aa", "b")]
        [InlineData("bb d", "bb")]
        [InlineData("d bb", "d")]
        [InlineData("aaa b", "aaa")]
        public void Test(string input, string expected)
        {
            var result = _highestScoringWordFinder.Find(input);

            result.Should().Be(expected);
        }
    }
}
