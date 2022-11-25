using System;
using System.Linq;

namespace Kata
{
    public static class VowelCount
    {
        private static char[] Vowels = new[] { 'a', 'e', 'i', 'o', 'u' };

        public static int GetVowelCount(string input) => input.Count(c => Vowels.Contains(c));
    }
}
