using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace Kata.Test
{
    public class BinaryTreeLevelSortTests
    {
        [Fact]
        public void Test()
        {
            var expected = new List<int>() { 1, 2, 3, 4, 5, 6 };

            var result = BinaryTreeLevelSort.Sort(
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
