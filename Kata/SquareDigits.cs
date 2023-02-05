using System;

namespace Kata
{
    public class SquareDigits
    {
        public static int Square(int n)
        {
            var result = 0;
            var multipler = 0;

            while (n > 0)
            {
                var digit = n % 10;
                result += (int)Math.Pow(digit, 2) * (int)Math.Pow(10, multipler);
                multipler += digit > 3 ? 2 : 1;
                n /= 10;
            }

            return result;
        }
    }
}
