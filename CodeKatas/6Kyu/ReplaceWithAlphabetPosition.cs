using System.Linq;

namespace CodeKatas._6Kyu
{
    class ReplaceWithAlphabetPosition
    {
        public static string AlphabetPosition(string text)
        {
            const string alphabet = "abcdefghijklmnopqrstuvwxyz";
            return text.ToLower()
                .Select(letter => alphabet.IndexOf(letter)).Where(index => index != -1)
                .Aggregate("", (current, index) => current + $"{index + 1} ")
                .Trim();
        }
    }
}
