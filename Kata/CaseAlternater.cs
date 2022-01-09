using System.Linq;

namespace Kata
{
    public sealed class CaseAlternater
    {
        public string AlternateCase(string input) => new string(input.Select(c => char.IsLetter(c) ? ToAlternate(c) : c).ToArray());

        private char ToAlternate(char c) => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c);
    }
}
