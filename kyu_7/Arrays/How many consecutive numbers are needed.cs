using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class How_many_consecutive_numbers_are_needed
{
    public static int Consecutive(int[] arr)
    {
        if (arr.Length == 0) return 0;
        return Enumerable.Range(arr.Min(), arr.Max() - arr.Min() + 1).Except(arr).Count();
    }
}
