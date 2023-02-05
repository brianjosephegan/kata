using FluentAssertions;
using Xunit;

namespace Kata.Test
{
    public class SquareDigitsTests
    {
        [Fact]
        public void Test()
        {
            SquareDigits.Square(0).Should().Be(0);
            SquareDigits.Square(9119).Should().Be(811181);
        }
    }
}
