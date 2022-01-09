using FluentAssertions;
using System.Collections.Generic;
using Xunit;
using static Kata.BinaryTreeLevelSorter;

namespace Kata.Tests
{
    public class BinaryTreeLevelSorterTests
    {
        private readonly BinaryTreeLevelSorter _binaryTreeLevelSorter = new BinaryTreeLevelSorter();

        [Fact]
        public void NullTest()
        {
            var result = _binaryTreeLevelSorter.Sort(null);

            result.Should().NotBeNull();
            result.Should().BeEmpty();
        }

        [Fact]
        public void BasicTest()
        {
            var expected = new List<int>() { 1, 2, 3, 4, 5, 6 };

            var result = _binaryTreeLevelSorter.Sort(
                new Node(
                    new Node(
                        null,
                        new Node(null, null, 4),
                        2),
                    new Node(
                        new Node(null, null, 5),
                        new Node(null, null, 6),
                        3
                        ),
                    1
                    )
                );

            result.Should().BeEquivalentTo(expected);
        }
    }
}
