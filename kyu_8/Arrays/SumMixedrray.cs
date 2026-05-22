using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class SumMixedrray
{
    public static int SumMix(object[] x)
    {
        int sum = 0;
        foreach (var item in x)
        {
            sum += int.Parse(item.ToString() ?? "0");
        }
        return sum;
    }
}
