using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Mathematics;

internal class Find_the_Slope
{
    public String slope(int[] points)
    {
        if (points[2] == points[0])
            return "undefined";
        return ((points[3] - points[1]) / (points[2] - points[0])).ToString();
    }
}
