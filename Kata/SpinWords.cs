using System;
using System.Linq;

namespace Kata
{
    public class SpinWords
    {
        public static string Spin(string sentence)
        {
            return string.Join(" ", sentence
                .Split(" ")
                .Select(w => w.Length < 5 ? w : new string(w.Reverse().ToArray())));
        }
    }
}
