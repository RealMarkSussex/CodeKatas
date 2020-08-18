using System;
using System.Collections.Generic;
using System.Text;

namespace CodeKatas
{
    class BinaryAddition
    {
        public static string AddBinary(int a, int b)
        {
            return Convert.ToString(a + b, 2);
        }
    }
}
