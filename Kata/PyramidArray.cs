using System.Linq;

namespace Kata
{
    public static class PyramidArray
    {
        public static int[][] Build(int levels)
        {
            int[][] result = new int[levels][];

            for (int i = 0; i < levels; i++)
            {
                result[i] = Enumerable
                    .Repeat(1, i + 1)
                    .ToArray();
            }

            return result;
        }
    }
}
