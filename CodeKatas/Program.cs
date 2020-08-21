using System;
using System.Collections.Generic;
using CodeKatas._3Kyu;
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

            Console.WriteLine(WeightForWeight.OrderWeight("2000 10003 1234000 44444444 9999 11 11 22 123"));

            Console.WriteLine(Calculator.LastDigit(new int[] { 3, 4, 2 }));
        }
    }
}
