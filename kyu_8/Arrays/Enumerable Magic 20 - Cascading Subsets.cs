using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class Enumerable_Magic_20___Cascading_Subsets
{
    public static IEnumerable<IEnumerable<int>> EachCons(int[] list, int n)
    {
        var res  = new List<List<int>>();
        for (int i = 0; i <= list.Length - n;i++)
        {
            res.Add(list.Skip(i).Take(n).ToList());
        }
        
        return res;

        //return Enumerable.Range(0, list.Length - n + 1)
        //                 .Select(i => list.Skip(i).Take(n));
    }
}
