using FluentAssertions;
using Xunit;
using System.Collections.Generic;

namespace Kata.Tests
{
    public class PyramidArrayBuilderTests
    {
        private readonly PyramidArrayBuilder _pyramidArrayBuilder = new PyramidArrayBuilder();

        [Theory]
        [MemberData(nameof(TestData))]
        public void BasicTests(int levels, int[][] expected)
        {
            var result = _pyramidArrayBuilder.Build(levels);

            result.Should().BeEquivalentTo(expected);
        }

        public static List<object[]> TestData
        {
            get
            {
                return new List<object[]>
                {
                    new object[]
                    {
                        0,
                        new int[][] {}
                    },
                    new object[]
                    {
                        1,
                        new int[][] { new int[] { 1 } }
                    },
                    new object[]
                    {
                        2,
                        new int[][] { new int[] { 1 }, new int[] { 1, 1 } }
                    },
                    new object[]
                    {
                        3,
                        new int[][] { new int[] { 1 }, new int[] { 1, 1 }, new int[] { 1, 1, 1 } }
                    }
                };
            }
        }
    }
}
