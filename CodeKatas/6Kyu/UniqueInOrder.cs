using System.Collections.Generic;
using System.Linq;

namespace CodeKatas._6Kyu
{
    public class UniqueInOrder
    {
        public static IEnumerable<T> Run<T>(IEnumerable<T> iterable)
        {
            var list = iterable.ToList();
            if (!list.Any())
            {
                return new List<T>();
            }
            var output = new List<T>();
            for (var i = 0; i < list.Count - 1; i++)
            {
                if (!list[i].Equals(list[i + 1]))
                {
                    output.Add(list[i]);
                }
            }
            output.Add(list.Last());
            //your code here...
            return output;
        }
    }
}
