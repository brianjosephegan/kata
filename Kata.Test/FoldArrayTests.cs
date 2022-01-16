using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace Kata.Test
{
    public class FoldArrayTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 1, new int[] { 6, 6, 3 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 9, 6 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 3, new int[] { 15 })]
        [InlineData(new int[] { -9, 9, -8, 8, 66, 23 }, 1, new int[] { 14, 75, 0 })]
        public void Test(int[] input, int runs, int[] expected)
        {
            var actual = FoldArray.Fold(input, runs);

            actual.Should().BeEquivalentTo(expected);
        }
    }
}
