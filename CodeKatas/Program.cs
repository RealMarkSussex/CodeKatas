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
            Console.WriteLine(MatrixDeterminant.Determinant(new int[][] { new[] { 1, 3, 5, 9 }, new[] { 1, 3, 1, 7 }, new[] { 4, 3, 9, 7 }, new []{ 5, 2, 0, 9} }));
            Console.WriteLine(MatrixDeterminant.Determinant(new int[][] { new[] { 2, 5, 3 }, new[] { 1, -2, -1 }, new[] { 1, 3, 4 } }));
            //var snailSort = SnailSort.Snail(new int[][]
            //{
            //    new[] {1, 2, 3},
            //    new[] {4, 5, 6},
            //    new[] {7, 8, 9}
            //});
            var snailSort = SnailSort.Snail(new int[0][]);
            Console.WriteLine();
            foreach (var num in snailSort)
            {
                Console.Write(num + " ");
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
