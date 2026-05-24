using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Algorithms;

internal class Decibel_Scale
{
    public static double DbScale(double intensity)
    {
        return 10 * Math.Log10(intensity * Math.Pow(10, 12));
    }
}
