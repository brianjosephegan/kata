using FluentAssertions;
using Xunit;

namespace Kata.Test
{
    public class SnailSortTests
    {
        [Fact]
        public void Test_Empty()
        {
            int[][] array =
            {
                new int[0],
            };
            var expected = new int[0];

            SnailSort.Sort(array).Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Test_One()
        {
            int[][] array =
            {
                new[] { 1 },
            };
            var expected = new[] { 1 };

            SnailSort.Sort(array).Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Test_Two()
        {
            int[][] array =
{
                new []{1, 2},
                new []{3, 4},
            };

            var expected = new[] { 1, 2, 4, 3 };

            SnailSort.Sort(array).Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Test_Three()
        {
            int[][] array =
            {
                new []{1, 2, 3},
                new []{4, 5, 6},
                new []{7, 8, 9}
            };
            var expected = new[] { 1, 2, 3, 6, 9, 8, 7, 4, 5 };

            SnailSort.Sort(array).Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void Test_Four()
        {
            int[][] array =
            {
                new []{1, 2, 3, 9},
                new []{4, 5, 6, 4},
                new []{7, 8, 9, 1},
                new []{1, 2, 3, 4},
            };
            var expected = new[] { 1, 2, 3, 9, 4, 1, 4, 3, 2, 1, 7, 4, 5, 6, 9, 8 };

            SnailSort.Sort(array).Should().BeEquivalentTo(expected);
        }
    }
}
