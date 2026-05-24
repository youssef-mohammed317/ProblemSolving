using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Mathematics;

internal class Quadrants
{
    public static int Quadrant(int x, int y)
    {
        if (x > 0)
        {
            return y > 0 ? 1 : 4;
        }
        return y < 0 ? 3 : 2;
    }
}
