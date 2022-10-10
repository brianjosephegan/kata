using FluentAssertions;
using Kata.SimpleEncryption;
using Xunit;

namespace Kata.Test.SimpleEncryption
{
    public class AlternatingSplitTests
    {
        [Theory]
        [InlineData("This is a test!", 0, "This is a test!")]
        [InlineData("This is a test!", 1, "hsi  etTi sats!")]
        [InlineData("This is a test!", 2, "s eT ashi tist!")]
        [InlineData("This is a test!", 3, " Tah itse sits!")]
        [InlineData("This is a test!", 4, "This is a test!")]
        [InlineData("This is a test!", -1, "This is a test!")]
        [InlineData("This kata is very interesting!", 1, "hskt svr neetn!Ti aai eyitrsig")]
        public void EncryptExampleTests(string input, int n, string expected)
        {
            AlternatingSplit.Encrypt(input, n).Should().Be(expected);
        }

        [Theory]
        [InlineData("This is a test!", 0, "This is a test!")]
        [InlineData("hsi  etTi sats!", 1, "This is a test!")]
        [InlineData("s eT ashi tist!", 2, "This is a test!")]
        [InlineData(" Tah itse sits!", 3, "This is a test!")]
        [InlineData("This is a test!", 4, "This is a test!")]
        [InlineData("This is a test!", -1, "This is a test!")]
        [InlineData("hskt svr neetn!Ti aai eyitrsig", 1, "This kata is very interesting!")]
        public void DecryptExampleTests(string input, int n, string expected)
        {
            AlternatingSplit.Decrypt(input, n).Should().Be(expected);
        }

        [Fact]
        public void EmptyTests()
        {
            AlternatingSplit.Encrypt(string.Empty, 0).Should().BeEmpty();
            AlternatingSplit.Decrypt(string.Empty, 0).Should().BeEmpty();
        }

        [Fact]
        public void NullTests()
        {
            AlternatingSplit.Encrypt(null, 0).Should().BeNull();
            AlternatingSplit.Decrypt(null, 0).Should().BeNull();
        }
    }
}
