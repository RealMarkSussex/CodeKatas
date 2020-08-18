using System;
using System.Linq;

namespace CodeKatas._6Kyu
{
    class NextBiggerNumberWithSameDigits
    {
        public static long NextBiggerNumber(long n)
        {
            var digitList = n.ToString().Select(digit => int.Parse(digit.ToString())).ToList();
            for (var i = digitList.Count - 1; i > 0; i--)
            {
                var temp = digitList[i - 1];
                digitList[i - 1] = digitList[i];
                digitList[i] = temp;
                if (digitList[i] < digitList[i - 1])
                {
                    break;
                }
            }
            var result = Convert.ToInt64(digitList.Aggregate("", (current, digit) => current + digit));
            if (result < n)
            {
                return -1;
            }
            return result;
        }
    }
}
