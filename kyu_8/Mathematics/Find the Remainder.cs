using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Mathematics;

internal class Find_the_Remainder
{
    public static int Remainder(int a, int b)
    {
        return Math.Max(a, b) % (Math.Min(a, b) == 0 ? throw new DivideByZeroException() : Math.Min(a, b));
    }
}
