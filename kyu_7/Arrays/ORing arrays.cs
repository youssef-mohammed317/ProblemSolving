using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class ORing_arrays
{
    public static int[] OrArrays(int[] arr1, int[] arr2, int d = 0)
    {

        return arr1.Length >= arr2.Length ? arr1.Select((x, i) => x | (i < arr2.Length ? arr2[i] : d)).ToArray() :
            arr2.Select((x, i) => x | (i < arr1.Length ? arr1[i] : d)).ToArray();
    }
}
