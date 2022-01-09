using FluentAssertions;
using Xunit;

namespace Kata.Tests
{
    public class ProductExceptSelfTests
    {
        private readonly ProductExceptSelf _productExceptSelf = new ProductExceptSelf();

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4 }, new int[] { 24, 12, 8, 6 })]
        [InlineData(new int[] { 1, 2, 0, 3, 3 }, new int[] { 0, 0, 18, 0, 0 })]
        public void Test(int[] input, int[] expected)
        {
            var result = _productExceptSelf.Compute(input);

            result.Should().BeEquivalentTo(expected);
        }
    }
}
