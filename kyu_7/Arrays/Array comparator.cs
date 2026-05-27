using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Array_comparator
{
    public static int MatchArrays(int[] v, int[] r)
    {
        return v.Count(x => r.Contains(x));
    }
}
