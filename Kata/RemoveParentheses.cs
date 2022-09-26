using System.Collections.Generic;
using System.Text;

namespace Kata
{
    public static class RemoveParentheses
    {
        public static string Remove(string input)
        {
            var result = new StringBuilder();
            var stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(input[i]);
                }
                else if (input[i] == ')')
                {
                    stack.Pop();
                }
                else if (stack.Count == 0)
                {
                    result.Append(input[i]);
                }
            }

            return result.ToString();
        }
    }
}
