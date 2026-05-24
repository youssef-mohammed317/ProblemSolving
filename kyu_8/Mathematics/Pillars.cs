using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Mathematics;

internal class Pillars_
{
    public static int Pillars(int numPill, int dist, int width)
    {
        if (numPill == 1) return 0;
        return (numPill - 2) * width + (numPill - 1) * dist * 100;
    }
}
