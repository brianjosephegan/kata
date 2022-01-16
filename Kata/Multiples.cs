using System.Collections.Generic;
using System.Linq;

namespace Kata
{
    public static class Multiples
    {
        public static List<int> Find(int integer, int limit)
            => Enumerable
                .Range(integer, limit - integer + 1)
                .Where(x => x % integer == 0)
                .ToList();
    }
}
