using FluentAssertions;
using Kata;
using Xunit;

namespace Kata.Test
{
    public class ValidBracesTests
    {
        [Fact]
        public void Test()
        {
            ValidBraces.AreValid("()").Should().BeTrue();
            ValidBraces.AreValid("[(])").Should().BeFalse();
        }
    }
}
