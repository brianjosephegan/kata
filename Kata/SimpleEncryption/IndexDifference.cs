using System;
using System.Linq;

namespace Kata.SimpleEncryption
{
    public static class IndexDifference
    {
        private const string CharRegion = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        private const string DigitRegion = "0123456789";
        private const string SpecialRegion = ".,:;-?! '()$%&\"";

        private static readonly string Region = $"{CharRegion}{DigitRegion}{SpecialRegion}";

        public static string Encrypt(string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return text;
            }

            var result = text.ToCharArray();

            if (result.Any(c => Region.IndexOf(c) < 0))
            {
                throw new Exception();
            }

            for (int i = 1; i < result.Length; i += 2)
            {
                if (char.IsUpper(result[i]))
                {
                    result[i] = char.ToLower(result[i]);
                }
                else
                {
                    result[i] = char.ToUpper(result[i]);
                }
            }

            var step1 = new string(result);

            for (int i = 0; i < result.Length - 1; i++)
            {
                var index = Region.IndexOf(step1[i]) - Region.IndexOf(step1[i + 1]);
                result[i + 1] = Region[(index + Region.Length) % Region.Length];
            }
            
            result[0] = Region[Region.Length - 1 - Region.IndexOf(result[0])];

            return new string(result);
        }

        public static string Decrypt(string encryptedText)
        {
            if (string.IsNullOrEmpty(encryptedText))
            {
                return encryptedText;
            }

            var result = encryptedText.ToCharArray();

            result[0] = Region[Region.Length - Region.IndexOf(result[0]) - 1];

            for (int i = 0; i < result.Length - 1; i++)
            {
                var index = Region.IndexOf(result[i]) - Region.IndexOf(result[i + 1]);
                result[i + 1] = Region[(index + Region.Length) % Region.Length];
            }

            for (int i = 1; i < result.Length; i += 2)
            {
                if (char.IsUpper(result[i]))
                {
                    result[i] = char.ToLower(result[i]);
                }
                else
                {
                    result[i] = char.ToUpper(result[i]);
                }
            }

            return new string(result);
        }
    }
}
