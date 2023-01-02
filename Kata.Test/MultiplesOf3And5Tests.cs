using FluentAssertions;
using Xunit;

namespace Kata.Test
{
    public class MultiplesOf3And5Tests
    {
        [Fact]
        public void Test()
        {
            MultiplesOf3And5.Get(10).Should().Be(23);
        }
    }
}