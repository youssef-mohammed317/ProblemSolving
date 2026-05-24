using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Algorithms;

internal class What_is_between
{
    public static int[] Between(int a, int b)
    {
        return Enumerable.Range(a, b - a + 1).ToArray();
    }
}
