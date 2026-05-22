using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class Beginner___Reduce_but_Grow
{
    public static int Grow(int[] x)
    {
        return x.Aggregate(1,(acc , next)  => acc * next);
    }
}
