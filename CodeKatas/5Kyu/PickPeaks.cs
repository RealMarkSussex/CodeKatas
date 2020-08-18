using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeKatas._5Kyu
{
    class PickPeaks
    {
        public static Dictionary<string, List<int>> GetPeaks(int[] arr)
        {
            var posList = new List<int>();
            var peakList = new List<int>();
            for (var i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i - 1] && arr[i] > arr[i + 1])
                {
                    posList.Add(Array.IndexOf(arr, arr[i]));
                    peakList.Add(arr[i]);
                }
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    posList.Add(i);
                    peakList.Add(arr[i]);
                }
            }
            return new Dictionary<string, List<int>>()
            {
                {"pos", posList},
                {"peaks", peakList}
            };
        }
    }
}
