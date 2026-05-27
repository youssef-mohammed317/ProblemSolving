using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Find_factors_of_a_number
{
    public static int[] Factors(int num)
    {
        if (num < 1) return [];
        return Enumerable.Range(1, num).Where(x => num % x == 0).OrderByDescending(x => x).ToArray();
    }
}
