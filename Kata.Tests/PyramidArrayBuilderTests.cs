using NUnit.Framework;
using System.Collections.Generic;

namespace Kata.Tests
{
    [TestFixture]
    public class PyramidArrayBuilderTests
    {
        private readonly PyramidArrayBuilder pyramidArrayBuilder = new PyramidArrayBuilder();

        [TestCaseSource(nameof(TestData))]
        public void BasicTests(int levels, int[][] expected)
        {
            var actual = pyramidArrayBuilder.Build(levels);

            CollectionAssert.AreEqual(expected, actual);
        }

        private static List<object[]> TestData
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
