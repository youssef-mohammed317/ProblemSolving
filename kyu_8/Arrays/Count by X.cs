using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class Count_by_X
{
    public static int[] CountBy(int x, int n)
    {
        return Enumerable.Range(1,n).Select(a => a * x).ToArray();
    }
}
