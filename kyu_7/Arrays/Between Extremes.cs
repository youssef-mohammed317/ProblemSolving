using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Between_Extremes
{
    public static int BetweenExtremes(int[] numbers)
    {
        return numbers.Max() - numbers.Min();
    }
}
