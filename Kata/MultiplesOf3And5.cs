using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class MultiplesOf3And5
    {
        public static int Get(int value)
        {
            return Enumerable
                .Range(0, value)
                .Where(i => i % 3 == 0 || i % 5 == 0)
                .Sum();
        }
    }
}
