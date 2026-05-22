using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class SpeedCode_2___Array_Madness
{
    public static bool ArrayMadness(int[] a, int[] b)
    {
        return a.Sum(x => x * x) > b.Sum(x => x * x * x);
    }
}
