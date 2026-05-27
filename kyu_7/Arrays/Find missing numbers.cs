using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Find_missing_numbers
{
    public static int[] FindMissingNumbers(int[] arr)
    {
        if (arr.Length == 0) return [];
        return Enumerable.Range(arr.Min(), arr.Max() - arr.Min() + 1).Except(arr).ToArray();
    }
}
