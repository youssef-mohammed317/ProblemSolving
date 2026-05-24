using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Algorithms;

internal class The_falling_speed_of_petals
{
    public static double SakuraFall(double v)
    {
        return v > 0 ? (80 * 5) / v : 0;
    }
}
