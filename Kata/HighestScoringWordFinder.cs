using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public class HighestScoringWordFinder
    {
        public string Find(string input)
        {
            string highWord = null;
            int highWordScore = 0;

            foreach (var word in input.Split(' '))
            {
                var wordScore = GetWordScore(word);
                if (wordScore > highWordScore)
                {
                    highWord = word;
                    highWordScore = wordScore;
                }
            }

            return highWord;
        }

        private int GetWordScore(string word) => word.Select(c => c % 32).Sum();
    }
}
