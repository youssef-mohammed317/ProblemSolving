using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Others;

internal class Compare_within_margin
{
    public static int CloseCompare(double a, double b, double margin = 0)
    {
        return Math.Abs(a - b) <= margin ? 0 : a > b ? 1 : -1;
    }
}
