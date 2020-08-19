using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeKatas._5Kyu
{
    class IntegersRecreationOne
    {
        public static string ListSquared(long m, long n)
        {
            var squaredDivisorsAndSums = new List<(long, long)>();

            for(var i = m; i <= n; i++)
            {
                var sumOfSquares = GetDivisors(i).Sum(divisor => divisor * divisor);
                if (IsSquare(sumOfSquares))
                {
                    squaredDivisorsAndSums.Add((i, sumOfSquares));
                }
            }
            var result = squaredDivisorsAndSums
                .Aggregate("",
                    (current, squaredDivisorAndSum) =>
                        current + $"[{squaredDivisorAndSum.Item1}, {squaredDivisorAndSum.Item2}], ");
            if (result.Length == 0)
            {
                return "[]";
            } 
            return "[" + result.Substring(0, result.Length - 2) + "]";
        }

        private static IEnumerable<long> GetDivisors(long num)
        {
            var divisors = new List<long>();
            for (var i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    divisors.Add(i);
                }
            }

            return divisors;
        }

        private static bool IsSquare(long num)
        {
            var squareRoot = Math.Sqrt(num);
            return squareRoot % 1 == 0;
        }
    }
}
