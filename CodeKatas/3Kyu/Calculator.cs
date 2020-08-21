using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace CodeKatas._3Kyu
{
    class Calculator
    {
        public static int LastDigit(int[] array)
        {
            var result = 1;
            for (var i = array.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    result += array[i];
                }
                else
                {
                    result += (int) Math.Pow(array[i - 1], array[i]);
                }
            }

            return int.Parse(result.ToString()[0].ToString());
        }
    }
}
