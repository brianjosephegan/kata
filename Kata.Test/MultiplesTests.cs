using FluentAssertions;
using Xunit;

namespace Kata.Test
{
    public class MultiplesTests
    {
        [Theory]
        [InlineData(1, 2, new int[] { 1, 2 })]
        [InlineData(5, 25, new int[] { 5, 10, 15, 20, 25 })]
        public void Test(int number, int limit, int[] expected)
        {
            var result = Multiples.Find(number, limit);

            result.Should().BeEquivalentTo(expected);
        }
    }
}
