using System.Linq;

namespace Kata
{
    public class HighAndLow
    {
        public static string Get(string input)
        {
            var numbers = input.Split(" ").Select(s => int.Parse(s));
            return $"{numbers.Max()} {numbers.Min()}";
        }
    }
}
