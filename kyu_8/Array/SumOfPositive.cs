using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Array;

internal class SumOfPositive
{
    public static int PositiveSum(int[] arr)
    {
        return arr.Sum(a => a > 0 ? a : 0);
    }
}
