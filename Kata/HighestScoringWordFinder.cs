using System.Linq;

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
