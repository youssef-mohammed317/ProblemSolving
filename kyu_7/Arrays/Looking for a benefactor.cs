using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Looking_for_a_benefactor
{
    public static long NewAvg(double[] arr, double navg)
    {
        var lst = (long)Math.Ceiling(((arr.Count() + 1) * navg - arr.Sum()));
        if (lst <= 0)
            throw new ArgumentException();
        return lst;
    }
}
