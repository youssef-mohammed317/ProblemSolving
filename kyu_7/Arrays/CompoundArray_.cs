using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class CompoundArray_
{
    public static int[] CompoundArray(int[] a, int[] b)
    {
        int[] result = new int[a.Length + b.Length];
        int i = 0, j = 0, k = 0;
        while (i < a.Length && j < b.Length)
        {
            result[k++] = a[i++];
            result[k++] = b[j++];
        }
        while (i < a.Length)
        {
            result[k++] = a[i++];
        }
        while (j < b.Length)
        {
            result[k++] = b[j++];
        }
        return result;
    }
}
