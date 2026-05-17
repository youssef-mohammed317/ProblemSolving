using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Array;

internal class GetTheMeanOfAnArray
{
    public static int GetAverage(int[] marks)
    {
        return (int)Math.Round(marks.Average());
    }
}
