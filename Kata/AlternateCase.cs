using System.Linq;

namespace Kata
{
    public static class AlternateCase
    {
        public static string Alternate(string input) => new string(
            input.Select(c => char.IsLetter(c) ? SwapCase(c) : c).ToArray()
            );

        private static char SwapCase(char c) => char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c);
    }
}
