using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class Beginner___Lost_Without_a_Map
{
    public static int[] Maps(int[] x)
    {
        return x.Select(a => 2 * a).ToArray();
    }
}
