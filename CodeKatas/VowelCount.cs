using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKatas
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
