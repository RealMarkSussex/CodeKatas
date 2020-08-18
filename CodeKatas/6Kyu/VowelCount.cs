using System.Linq;

namespace CodeKatas._6Kyu
{
    class VowelCount
    {
        public static int GetVowelCount(string str)
        {
            const string vowels = "aeiou";
            return str.Count(letter => vowels.Contains(letter));
        }
    }
}
