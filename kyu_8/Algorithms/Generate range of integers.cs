using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Algorithms;

internal class Generate_range_of_integers
{
    public static int[] GenerateRange(int min, int max, int step)
    {
        int[] arr = new int[(max - min + step) / step];
        for (int i = min, k = 0; i <= max; i += step)
            arr[k++] = i;
        return arr;
    }
}
