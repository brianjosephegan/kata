using FluentAssertions;
using System.Collections.Generic;
using Xunit;

namespace Kata.Tests
{
    public class ArrayFolderTests
    {
        private readonly ArrayFolder _arrayFolder = new ArrayFolder();

        [Theory]
        [MemberData(nameof(Data))]
        public void Test(int[] input, int runs, int[] expected)
        {
            var actual = _arrayFolder.Fold(input, runs);

            actual.Should().BeEquivalentTo(expected);
        }

        public static List<object[]> Data
        {
            get
            {
                return new List<object[]>
                {
                    new object[]
                    {
                        new int[] { 1, 2, 3, 4, 5 },
                        1,
                        new int[] { 6, 6, 3 }
                    },
                    new object[]
                    {
                        new int[] { 1, 2, 3, 4, 5 },
                        2,
                        new int[] { 9, 6 }
                    },
                    new object[]
                    {
                        new int[] { 1, 2, 3, 4, 5 },
                        3,
                        new int[] { 15 }
                    },
                    new object[]
                    {
                        new int[] { -9, 9, -8, 8, 66, 23 },
                        1,
                        new int[] { 14, 75, 0 }
                    },
                };
            }
        }
    }
}
