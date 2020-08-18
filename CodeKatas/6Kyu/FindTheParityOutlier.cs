using System.Linq;

namespace CodeKatas._6Kyu
{
    class FindTheParityOutlier
    {
        public static int Find(int[] integers)
        {
            var numOfEven = integers.Count(integer => integer % 2 == 0);
            return numOfEven == 1 ? 
                integers.First(integer => integer % 2 == 0) : integers.First(integer => integer % 2 != 0);
        }
    }
}
