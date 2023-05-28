namespace Kata
{
    public static class ProductOfLargestPair
    {
        public static int MaxProduct(int[] array)
        {
            var max = 0;
            var secondMax = 0;

            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    secondMax = max;
                    max = array[i];
                }
                else if (array[i] > secondMax)
                {
                    secondMax = array[i];
                }
            }

            return max * secondMax;
        }
    }
}
