using System.Linq;
using System.Text;

namespace Kata.SimpleEncryption
{
    public static class AlternatingSplit
    {
        public static string Encrypt(string text, int n)
        {
            if (string.IsNullOrWhiteSpace(text) || n <= 0)
            {
                return text;
            }

            string result = text;

            for (int i = 0; i < n; i++)
            {
                result = string.Concat(
                    new string(result.Where((c, i) => i % 2 != 0).ToArray()),
                    new string(result.Where((c, i) => i % 2 == 0).ToArray()));
            }

            return result;
        }

        public static string Decrypt(string encryptedText, int n)
        {
            if (string.IsNullOrWhiteSpace(encryptedText) || n <= 0)
            {
                return encryptedText;
            }

            string result = encryptedText;

            for (int i = 0; i < n; i++)
            {
                var firstHalf = result.Where((c, i) => i < result.Length / 2);
                var secondHalf = result.Where((c, i) => i >= result.Length / 2);
                var stringBuilder = new StringBuilder();

                using (var firstHalfEnumerator = firstHalf.GetEnumerator())
                using (var secondHalfEnumerator = secondHalf.GetEnumerator())
                {
                    while (stringBuilder.Length != result.Length)
                    {
                        if (secondHalfEnumerator.MoveNext())
                        {
                            stringBuilder.Append(secondHalfEnumerator.Current);
                        }

                        if (firstHalfEnumerator.MoveNext())
                        {
                            stringBuilder.Append(firstHalfEnumerator.Current);
                        }
                    }
                }

                result = stringBuilder.ToString();
            }

            return result;
        }
    }
}
