using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Algorithms;

internal class Points_of_Reflection
{
    public static int[] SymmetricPoint(int[] p, int[] q)
    {
        return [q[0] * 2 - p[0], q[1] * 2 - p[1]];
    }
}
