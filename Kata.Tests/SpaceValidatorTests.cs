using FluentAssertions;
using Xunit;

namespace Kata.Tests
{
    public class SpaceValidatorTests
    {
        private readonly SpaceValidator _spaceValidator = new SpaceValidator();

        [Theory]
        [InlineData("Hello world", true)]
        [InlineData(" Hello world", false)]
        [InlineData("Hello world ", false)]
        [InlineData("Hello", true)]
        [InlineData("Helloworld", true)]
        public void Test(string input, bool expected)
        {
            var result = _spaceValidator.Validate(input);

            result.Should().Be(expected);
        }
    }
}
