using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace Kata.Test
{
    public class PyramidArrayTests
    {
        [Theory]
        [MemberData(nameof(TestData))]
        public void Test(int levels, int[][] expected)
        {
            var result = PyramidArray.Build(levels);

            result.Should().BeEquivalentTo(expected);
        }

        public static List<object[]> TestData =>
            new List<object[]>
            {
                new object[] { 0, new int[][] {} },
                new object[] { 1, new int[][] { new int[] { 1 } } },
                new object[] { 2, new int[][] { new int[] { 1 }, new int[] { 1, 1 } } },
                new object[] { 3, new int[][] { new int[] { 1 }, new int[] { 1, 1 }, new int[] { 1, 1, 1 } } }
            };
    }
}
