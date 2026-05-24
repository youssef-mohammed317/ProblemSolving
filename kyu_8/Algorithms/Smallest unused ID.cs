using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Algorithms;

internal class Smallest_unused_ID
{
    public static int NextId(int[] ids)
    {
        Array.Sort(ids); int i;
        for (i = 0; i < ids.Length; i++)
        {
            if (i != ids[i])
                return i;
        }
        return i;
        //return Enumerable.Range(0, ids.Length + 1).Except(ids).Min();

    }
}
