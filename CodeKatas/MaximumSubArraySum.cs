using System.Collections.Generic;
using System.Linq;

namespace CodeKatas
{
    class MaximumSubArraySum
    {
        public static int MaxSequence(int[] arr)
        {
            if (!arr.Any())
            {
                return 0;
            }
            var sums = new List<int>();
            for (var i = 0; i <= arr.Length; i++)
            {
                for (var j = 0; j <= arr.Length; j++)
                {
                    sums.Add(arr.Skip(i).Take(j).Sum());
                }
            }
            return sums.Max();
        }
    }
}
