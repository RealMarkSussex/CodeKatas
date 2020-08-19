using System;
using System.Linq;

namespace CodeKatas._7Kyu
{
    class HighestAndLowest
    {
        public static string HighAndLow(string numbers)
        {
            var nums = Array.ConvertAll(numbers.Split(" "), int.Parse);
            return nums.Max() + " " + nums.Min();
        }
    }
}
