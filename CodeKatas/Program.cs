using System;
using System.Collections.Generic;
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
