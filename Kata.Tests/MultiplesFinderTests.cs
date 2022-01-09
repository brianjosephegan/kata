using FluentAssertions;
using Xunit;
using System.Collections.Generic;

namespace Kata.Tests
{
    public class MultiplesFinderTests
    {
        private readonly MultiplesFinder _multiplesFinder = new MultiplesFinder();

        [Theory]
        [MemberData(nameof(TestData))]
        public void Test(int number, int limit, List<int> expected)
        {
            var result = _multiplesFinder.Find(number, limit);

            result.Should().BeEquivalentTo(expected);
        }

        public static IEnumerable<object[]> TestData =>
            new List<object[]>
            {
                new object[] { 1, 2, new List<int> { 1, 2 } },
                new object[] { 5, 25, new List<int> { 5, 10, 15, 20, 25 } },
            };
    }
}
