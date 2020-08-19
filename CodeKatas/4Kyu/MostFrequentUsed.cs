using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeKatas._4Kyu
{
    class MostFrequentUsed
    {
        public static List<string> Top3(string s)
        {
            var words = s
                .Replace(",", string.Empty)
                .Split(" ")
                .Select(w => w.ToLower());

            words = words
                .Select(word =>
                    new string(word
                        .Where(c => char.IsLetter(c) || c.ToString() == "'").ToArray()));

            words =  words
                .Where(w => w != string.Empty && w.Any(char.IsLetter))
                .GroupBy(w => w)
                .OrderByDescending(w => w.Count())
                .Select(w => w.Key);
            return words.Take(3).ToList();
        }
    }
}
