using NUnit.Framework;

namespace Kata.Tests
{
    [TestFixture]
    public sealed class CaseAlternaterTests
    {
        private readonly CaseAlternater caseAlternater = new CaseAlternater();

        [TestCase("HELLO WORLD", "hello world")]
        [TestCase("hello world", "HELLO WORLD")]
        [TestCase("HELLO world", "hello WORLD")]
        [TestCase("hEllO wOrld", "HeLLo WoRLD")]
        [TestCase("12345", "12345")]
        [TestCase("1A2B3C4D5E", "1a2b3c4d5e")]
        [TestCase("sTRING.tOaLTERNATINGcASE", "String.ToAlternatingCase")]
        public void Test(string expected, string input)
        {
            Assert.AreEqual(expected, caseAlternater.AlternateCase(input));
        }
    }
}
