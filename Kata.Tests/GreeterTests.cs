using FluentAssertions;
using Xunit;

namespace Kata.Tests
{
    public class GreeterTests
    {
        private readonly Greeter _greeter = new Greeter();

        [Theory]
        [InlineData("Welcome", "english")]
        [InlineData("Welkom", "dutch")]
        [InlineData("Welcome", "IP_ADDRESS_INVALID")]
        [InlineData("Welcome", "")]
        [InlineData("Welcome", "2")]
        public void Test(string expected, string input)
        {
            var result = _greeter.Greet(input);

            result.Should().Be(expected);
        }
    }
}
