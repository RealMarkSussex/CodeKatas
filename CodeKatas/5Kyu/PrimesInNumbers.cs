using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKatas._5Kyu
{
    class PrimesInNumbers
    {
        public static string Factors(int lst)
        {
            var currentNum = lst;
            var numsAndPowers = new Dictionary<int, int>();
            for (var i = 2; i <= Math.Sqrt(lst); i++)
            {
                if (IsPrime(i) && currentNum % i == 0)
                {
                    currentNum /= i;
                    numsAndPowers.Add(i, 1);
                    while (currentNum % i == 0)
                    {
                        currentNum /= i;
                        numsAndPowers[i]++;
                    }
                }
            }

            //var numsAndPowers = primeFactors.ToDictionary(primeFactor => primeFactor, primeFactor => 1);

            //while (currentNum > 1)
            //{
            //    for (var index = 0; index < primeFactors.Count; index++)
            //    {
            //        var primeFactor = primeFactors[index];
            //        if (currentNum % primeFactor == 0)
            //        {
            //            currentNum /= primeFactor;
            //            numsAndPowers[primeFactor]++;
            //        }
            //    }
            //}

            var result = "";
            foreach (var (key, value) in numsAndPowers)
            {
                if (value == 1)
                {
                    result += $"({key})";
                }
                else
                {
                    result += $"({key}**{value})";
                }
            }
            return result;
        }

        private static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (var i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;

        }
    }
}
