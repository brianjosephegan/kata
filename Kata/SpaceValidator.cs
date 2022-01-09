using System.Linq;

namespace Kata
{
    public class SpaceValidator
    {
        public bool Validate(string input) =>
            input == string.Empty ||
            !input.StartsWith(string.Empty) ||
            !input.EndsWith(string.Empty) ||
            !input.Split(' ').Any(s => s == string.Empty)
            ;
    }
}
