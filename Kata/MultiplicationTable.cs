using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public static class MultiplicationTable
    {
        public static int[,] Create(int size)
        {
            var result = new int[size,size];

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result[i, j] = (j + 1) * (i + 1);
                }
            }

            return result;
        }
    }
}
