using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Number_Pairs
{
    public static int[] getLargerNumbers(int[] a, int[] b)
    {
        return Enumerable.Range(0, a.Length).Select(x => Math.Max(a[x], b[x])).ToArray();
    }
}
