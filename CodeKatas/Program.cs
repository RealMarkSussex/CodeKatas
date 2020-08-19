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
            var simple = PickPeaks.GetPeaks(new[] { 0, 1, 2, 5, 1, 0 });
            var harder = PickPeaks.GetPeaks(new[] { 3, 2, 3, 6, 4, 1, 2, 3, 2, 1, 2, 3 });
            var plateauPeak = PickPeaks.GetPeaks(new[] { 1, 2, 2, 2, 1 });
            var plateauNoPeak = PickPeaks.GetPeaks(new[] { 1, 2, 2, 2, 3 });
            PrintPickPeaks(simple, "Simple test case");
            PrintPickPeaks(harder, "Harder test case");
            PrintPickPeaks(plateauPeak, "Test case with a plateau that is a peak");
            PrintPickPeaks(plateauNoPeak, "Test case that is a plateau that is not a peak");
            Console.WriteLine(PrimesInNumbers.Factors(7775460));
            Console.WriteLine(IntegersRecreationOne.ListSquared(1, 250));
            var top3Words = MostFrequentUsed.Top3("In a village of La Mancha, the name of which I have no desire to call to\",\r\n                  \"mind, there lived not long since one of those gentlemen that keep a lance\",\r\n                  \"in the lance-rack, an old buckler, a lean hack, and a greyhound for\",\r\n                  \"coursing. An olla of rather more beef than mutton, a salad on most\",\r\n                  \"nights, scraps on Saturdays, lentils on Fridays, and a pigeon or so extra\",\r\n                  \"on Sundays, made away with three-quarters of his income.");
            Console.WriteLine();
            var i = 0;
            foreach (var word in top3Words)
            {
                Console.Write(word + " ");
                if (i == 10)
                {
                    Console.WriteLine();
                    i = 0;
                }

                i++;
            }
        }

        private static void PrintPickPeaks(Dictionary<string, List<int>> result, string testCase)
        {
            Console.WriteLine("\n------------------------------------------------------");
            Console.WriteLine($"{testCase}");
            Console.WriteLine("pos => ");
            foreach (var number in result["pos"])
            {
                Console.Write($", {number}");
            }

            Console.WriteLine("\npeaks => ");
            foreach (var number in result["peaks"])
            {
                Console.Write($", {number}");
            }
        }
    }
}
