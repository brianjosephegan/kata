using System.Linq;

namespace Kata
{
    public static class AsciiTotal
    {
        public static int SumCharacrters(string input) => input.Select(c => (int)c).Sum();
    }
}
