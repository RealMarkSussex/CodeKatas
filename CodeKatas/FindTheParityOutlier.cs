using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKatas
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
