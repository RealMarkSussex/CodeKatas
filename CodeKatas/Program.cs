using System;
using System.Collections.Generic;
using CodeKatas._4Kyu;
using CodeKatas._5Kyu;
using CodeKatas._6Kyu;

namespace CodeKatas
{
    class Program
    {
        static void Main(string[] args)
        {
            var anagrams = WhereMyAnagramsAt.Anagrams("racer",
                new List<string>
                    {"carer", "arcre", "carre", "racrs", "racers", "arceer", "raccer", "carrer", "cerarr"});
            foreach (var anagram in anagrams)
            {
                Console.WriteLine(anagram);
            }
        }
    }
}
