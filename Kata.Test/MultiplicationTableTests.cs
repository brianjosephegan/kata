using FluentAssertions;
using Xunit;

namespace Kata.Test
{
    public class MultiplicationTableTests
    {
        [Fact]
        public void Test()
        {
            var expected = new int[,]
            {
                { 1, 2, 3 },
                { 2, 4, 6 },
                { 3, 6, 9 }
            };

            var result = MultiplicationTable.Create(3);

            result.Should().BeEquivalentTo(expected);
        }
    }
}
