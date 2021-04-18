using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class MultiplesFinder
    {
        public List<int> Find(int integer, int limit)
        {
            return Enumerable
                .Range(integer, limit - integer + 1)
                .Where(x => x % integer == 0)
                .ToList();
        }
    }
}
