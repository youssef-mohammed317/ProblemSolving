using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class To_square_root__or_not_to_square_root
{
    public static int[] SquareOrSquareRoot(int[] array)
    {
        return array.Select(x => { 

            var sqrt = (int) Math.Sqrt(x);

            return sqrt * sqrt == x ? sqrt : x * x;
            
            }).ToArray();
    }
}
