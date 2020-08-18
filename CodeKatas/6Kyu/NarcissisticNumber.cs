using System;
using System.Linq;

namespace CodeKatas._6Kyu
{
    class NarcissisticNumber
    {
        public static bool Narcissistic(int value)
        {
            var digitList = value.ToString().Select(digit => int.Parse(digit.ToString())).ToList();
            return digitList.Sum(d => Math.Pow(d, digitList.Count)) == value;
        }
    }
}
