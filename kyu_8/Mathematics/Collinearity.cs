using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Mathematics;

internal class Collinearity_
{
    public static bool Collinearity(int x1, int y1, int x2, int y2)
    {
        if ((x1 == 0 && y1 == 0) || (x2 == 0 && y2 == 0)) return true;

        return (x1 * y2 == y1 * x2);
    }
}
