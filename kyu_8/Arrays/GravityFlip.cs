using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class GravityFlip
{

    public static int[] Flip(char dir, int[] arr)
    {
        if (dir == 'R')
        {
            Array.Sort(arr);
        }
        else if (dir == 'L')
        {
            Array.Sort(arr);
            Array.Reverse(arr);
        }
        return arr;
    }
}
