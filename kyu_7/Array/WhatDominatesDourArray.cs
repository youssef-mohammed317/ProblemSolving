using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Array;

internal class WhatDominatesDourArray
{
    public static int WhoDominates(int[] array)
    {
        var dic = new Dictionary<int, int>();
        foreach (var n in array)
        {
            if (dic.ContainsKey(n))
                dic[n]++;
            else
                dic[n] = 1;
        }
        int half = array.Length / 2;
        var lst = dic.Where(kv => kv.Value > half);
        return lst.Any() ? lst.FirstOrDefault().Key : -1;
        //return arr.GroupBy(x => x)
        //       .FirstOrDefault(x => x.Count() > arr.Length / 2)?.Key ?? -1;

    }
}
