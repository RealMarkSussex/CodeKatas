using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKatas
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
