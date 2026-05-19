using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars;

internal class CalculateAverag
{
    public static double FindAverage(double[] array)
    {
        if (array == null || array.Length == 0) return 0;
        return array.Average();
    }
}
