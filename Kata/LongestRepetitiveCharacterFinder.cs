using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class LongestRepetitiveCharacterFinder
    {
        public Tuple<char?, int> Find(string input)
        {
            var maxCharToCount = new Tuple<char?, int>(null, 0);

            char? currentChar = null;
            int currentCharCount = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (i == 0)
                {
                    currentChar = input[i];
                }

                if (currentChar == input[i])
                {
                    currentCharCount++;
                }
                else
                {
                    if (currentCharCount > maxCharToCount.Item2)
                    {
                        maxCharToCount = new Tuple<char?, int>(currentChar, currentCharCount);
                    }

                    currentChar = input[i];
                    currentCharCount = 1;
                }

                if (i == input.Length - 1 && currentCharCount > maxCharToCount.Item2)
                {
                    maxCharToCount = new Tuple<char?, int>(currentChar, currentCharCount);
                }
            }

            return maxCharToCount;
        }
    }
}
