using NUnit.Framework;

namespace Kata.Tests
{
    [TestFixture]
    public sealed class GreeterTests
    {
        private readonly Greeter greeter = new Greeter();

        [TestCase("Welcome", "english")]
        [TestCase("Welkom", "dutch")]
        [TestCase("Welcome", "IP_ADDRESS_INVALID")]
        [TestCase("Welcome", "")]
        [TestCase("Welcome", "2")]
        public void Test(string expected, string input)
        {
            Assert.AreEqual(expected, greeter.Greet(input));
        }
    }
}
