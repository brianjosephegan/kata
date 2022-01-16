using FluentAssertions;
using Xunit;

namespace Kata.Test
{
    public class ProductExceptSelfTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 24, 12, 8, 6 })]
        [InlineData(new int[] { 1, 2, 0, 3, 3 }, new int[] { 0, 0, 18, 0, 0 })]
        public void Test(int[] input, int[] expected)
        {
            var result = ProductExceptSelf.Compute(input);

            result.Should().BeEquivalentTo(expected);
        }
    }
}
