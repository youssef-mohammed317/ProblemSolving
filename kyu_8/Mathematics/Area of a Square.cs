using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Mathematics;

internal class Area_of_a_Square
{
    public static double SquareArea(double a)
    {
        a = a * 2 / Math.PI;
        return a * a;
    }
}
