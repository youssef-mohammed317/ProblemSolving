using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class Counting_sheep
{
    public static int CountSheeps(bool[] sheeps)
    {
        return sheeps.Count(s => s);
    }
}
