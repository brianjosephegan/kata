using FluentAssertions;
using Kata;
using Xunit;

namespace Kata.Test
{
    public class RemoveParenthesesTests
    {
        [Theory]
        [InlineData("exampleexample", "example(unwanted thing)example")]
        [InlineData("a e", "a (bc d)e")]
        [InlineData("a", "a(b(c))")]
        [InlineData("hello example  something", "hello example (words(more words) here) something")]
        [InlineData("  ", "(first group) (second group) (third group)")]
        public static void Test(string expected, string input)
        {
            RemoveParentheses.Remove(input).Should().Be(expected);
        }
    }
}
