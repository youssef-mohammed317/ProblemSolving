using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Mathematics;

internal class Area_or_Perimeter
{
    public static int AreaOrPerimeter(int l, int w)
    {
        return l == w ? l * w : (l + w) * 2;
    }
}
