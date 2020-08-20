using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKatas._5Kyu
{
    class WeightForWeight
    {
        public static string OrderWeight(string strng)
        {
            var numbers = strng.Split(" ");
            Array.Sort(numbers, string.Compare);
            var orderedNumbers = numbers
                .OrderBy(num => num.Sum(l => int.Parse(l.ToString()))).ToArray();
            return orderedNumbers
                .Aggregate("", (current, orderedNumber) => current + (orderedNumber + " "))
                .Trim();
        }
    }
}
