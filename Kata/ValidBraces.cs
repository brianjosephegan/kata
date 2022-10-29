using System.Collections.Generic;

namespace Kata
{
    public static class ValidBraces
    {
        private const string OpeningBraces = "([{";
        private const string ClosingBraces = ")]}";

        public static bool AreValid(string input)
        {
            var braces = new Stack<char>();

            foreach (var c in input)
            {
                if (OpeningBraces.Contains(c))
                {
                    braces.Push(c);
                }
                else if (ClosingBraces.Contains(c))
                {
                    if (braces.TryPop(out var lastBrace))
                    {
                        if (OpeningBraces.IndexOf(lastBrace) != ClosingBraces.IndexOf(c))
                        {
                            return false;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return braces.Count == 0;
        }
    }
}