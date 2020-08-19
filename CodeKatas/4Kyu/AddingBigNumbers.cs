using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace CodeKatas._4Kyu
{
    class AddingBigNumbers
    {
        public static string Add(string a, string b)
        {
            return (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
        }
    }
}
