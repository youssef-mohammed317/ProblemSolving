using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Algorithms;

internal class Expressions_Matter
{
    public static int ExpressionsMatter(int a, int b, int c)
    {
        return new int[] {a * b * c, a * b + c, a * (b + c), a + b * c, (a + b) * c, a + b + c}.Max();
    }
}
