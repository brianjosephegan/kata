using FluentAssertions;
using Xunit;

namespace Kata.Tests
{
    public class CaseAlternaterTests
    {
        private readonly CaseAlternater _caseAlternater = new CaseAlternater();

        [Theory]
        [InlineData("HELLO WORLD", "hello world")]
        [InlineData("hello world", "HELLO WORLD")]
        [InlineData("HELLO world", "hello WORLD")]
        [InlineData("hEllO wOrld", "HeLLo WoRLD")]
        [InlineData("12345", "12345")]
        [InlineData("1A2B3C4D5E", "1a2b3c4d5e")]
        [InlineData("sTRING.tOaLTERNATINGcASE", "String.ToAlternatingCase")]
        public void Test(string expected, string input)
        {
            var result = _caseAlternater.AlternateCase(input);

            result.Should().Be(expected);
        }
    }
}
