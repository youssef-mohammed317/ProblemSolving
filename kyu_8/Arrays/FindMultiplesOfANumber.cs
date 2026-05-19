using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class FindMultiplesOfANumber
{
    public static List<int> FindMultiples(int n, int limit)
    {
        var res = new List<int>();
        for (int i = n; i <= limit; i++)
        {
            if (i % n == 0)
                res.Add(i);
        }
        return res;
    }
}
