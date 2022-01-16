using System;

namespace Kata
{
    public static class FoldArray
    {
        public static int[] Fold(int[] array, int runs)
        {
            int[] result = array;

            for (int i = 0; i < runs; i++)
            {
                result = Fold(result);
            }

            return result;
        }

        private static int[] Fold(int[] array)
        {
            var resultLength = (int)Math.Ceiling(array.Length / 2.0);
            int[] result = new int[resultLength];

            int low = 0;
            int high = array.Length - 1;

            for (int i = 0; i < result.Length; i++)
            {
                if (low == high)
                {
                    result[i] = array[low];
                }
                else
                {
                    result[i] = array[low] + array[high];
                }

                low++;
                high--;
            }

            return result;
        }
    }
}
