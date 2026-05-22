using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class Square_n_Sum
{
    public static int SquareSum(int[] numbers)
    {
        return numbers.Sum(x => x * x);
    }
}
