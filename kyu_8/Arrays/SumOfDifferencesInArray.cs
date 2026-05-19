using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class SumOfDifferencesInArray
{
    public static int SumOfDifferences(int[] arr)
    {
        Array.Sort(arr);
        Array.Reverse(arr);
        return arr.Skip(1).Select((x, i) => arr[i] - x).Sum();
        //return arr.Max() - arr.Min();
    }
}
