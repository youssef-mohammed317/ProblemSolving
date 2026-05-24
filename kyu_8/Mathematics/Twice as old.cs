using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Mathematics;

internal class Twice_as_old
{
    public static int TwiceAsOld(int dadYears, int sonYears)
    {
        return Math.Abs(dadYears - sonYears * 2);
    }
}
