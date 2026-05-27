using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Sum_of_differences_between_products_and_LCMs
{
    public static int GetLcmOfPair(int i, int j)
    {
        for (int k = Math.Min(i, j); k > 1; k--)
        {
            if (i % k == 0 && j % k == 0) return i * j / k;
        }
        return i * j;
    }
    public static int SumDifferencesBetweenProductsAndLCMs(int[][] pairs)
    {
        return pairs.Select(p => p[0] * p[1] - GetLcmOfPair(p[0], p[1])).Sum();
    }
}
