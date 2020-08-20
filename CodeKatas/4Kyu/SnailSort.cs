using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKatas._4Kyu
{
    class SnailSort
    {
        public static int[] Snail(int[][] array)
        {
            if (array[0].Any())
            {
                return new int[0];
            }
            if (array[0].Length == 0)
            {
                return new int[0];
            }
            if (!array.Any())
            {
                return new int[0];
            }
            if (array.Length == 1)
            {
                return new []{ array[0][0] };
            }
            var result = new List<int>();
            result.AddRange(array[0]);
            for (var i = 1; i < array.Length - 1; i++)
            {
                result.Add(array[i][array.Length - 1]);
            }
            result.AddRange(array[array.Length - 1].Reverse());
            for (var i = array.Length - 2; i >= 1; i--)
            {
                result.Add(array[i][0]);
            }

            var middle = array
                .Where((arr, i) => i != 0 && i != array.Length - 1)
                .Select(arr => arr.Where((item, i) => i != 0 && i != array.Length - 1).ToArray())
                .ToArray();
            result.AddRange(Snail(middle));
            return result.ToArray();
        }
    }
}
