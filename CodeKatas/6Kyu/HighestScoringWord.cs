using System.Linq;

namespace CodeKatas._6Kyu
{
    class HighestScoringWord
    {
        public static string High(string s)
        {
            var words = s.ToLower().Split(" ");
            const string alphabet = "abcdefghijklmnopqrstuvwxyz";
            var greatestValue = int.MinValue;
            var greatestValueWord = "";
            foreach (var word in words)
            {
                var wordValue = word.Sum(w => alphabet.IndexOf(w));
                if (wordValue > greatestValue)
                {
                    greatestValue = wordValue;
                    greatestValueWord = word;
                }
            }
            return greatestValueWord;
        }
    }
}
