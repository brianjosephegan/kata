using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Kata.Tests
{
    [TestFixture]
    public class ArrayFolderTests
    {
        private readonly ArrayFolder arrayFolder = new ArrayFolder();

        [TestCaseSource(nameof(TestData))]
        public void BasicTests(int[] input, int runs, int[] expected)
        {
            var actual = arrayFolder.Fold(input, runs);

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
