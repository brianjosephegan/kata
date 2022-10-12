using FluentAssertions;
using Kata.SimpleEncryption;
using Xunit;

namespace Kata.Test.SimpleEncryption
{
    public class IndexDifferenceTests
    {
        [Theory]
        [InlineData("Do the kata \"Kobayashi-Maru-Test!\" Endless fun and excitement when finding a solution!", "$-Wy,dM79H'i'o$n0C&I.ZTcMJw5vPlZc Hn!krhlaa:khV mkL;gvtP-S7Rt1Vp2RV:wV9VuhO Iz3dqb.U0w")]
        [InlineData("This is a test!", "5MyQa9p0riYplZc")]
        [InlineData("This kata is very interesting!", "5MyQa79H'ijQaw!Ns6jVtpmnlZ.V6p")]
        public void EncryptExampleTests(string input, string expected)
        {
            IndexDifference.Encrypt(input).Should().Be(expected);
        }

        [Theory]
        [InlineData("$-Wy,dM79H'i'o$n0C&I.ZTcMJw5vPlZc Hn!krhlaa:khV mkL;gvtP-S7Rt1Vp2RV:wV9VuhO Iz3dqb.U0w", "Do the kata \"Kobayashi-Maru-Test!\" Endless fun and excitement when finding a solution!")]
        [InlineData("5MyQa9p0riYplZc", "This is a test!")]
        [InlineData("5MyQa79H'ijQaw!Ns6jVtpmnlZ.V6p", "This kata is very interesting!")]
        public void DecryptExampleTests(string input, string expected)
        {
            IndexDifference.Decrypt(input).Should().Be(expected);
        }

        [Fact]
        public void EmptyTests()
        {
            IndexDifference.Encrypt(string.Empty).Should().BeEmpty();
            IndexDifference.Decrypt(string.Empty).Should().BeEmpty();
        }

        [Fact]
        public void NullTests()
        {
            IndexDifference.Encrypt(null).Should().BeNull();
            IndexDifference.Decrypt(null).Should().BeNull();
        }
    }
}
