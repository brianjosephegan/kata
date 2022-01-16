using FluentAssertions;
using Xunit;

namespace Kata.Test
{
    public class ValidSpacesTests
    {
        [Theory]
        [InlineData("Hello world", true)]
        [InlineData(" Hello world", false)]
        [InlineData("Hello world ", false)]
        [InlineData("Hello", true)]
        [InlineData("Helloworld", true)]
        public void Test(string input, bool expected)
        {
            var result = ValidSpaces.Validate(input);

            result.Should().Be(expected);
        }
    }
}
