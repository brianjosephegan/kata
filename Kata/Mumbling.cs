using System.Linq;

namespace Kata
{
    public class Mumbling
    {
        public static string Mumble(string input)
        {
            return string.Join(
                "-",
                Enumerable.Range(0, input.Length).Select(i => $"{char.ToUpper(input[i])}{new string(char.ToLower(input[i]), i)}"));
        }
    }
}
