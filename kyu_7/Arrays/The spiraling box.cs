using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class The_spiraling_box
{
    public static int[,] CreateBox(int n, int m)
    {
        var res = new int[m, n];

        int maxK = (Math.Min(m, n) + 1) / 2;
        for (int k = 1; k <= maxK; k++)
        {
            for (int j = k - 1; j <= n - k; j++)
            {
                res[k - 1, j] = k; // i == 0
                res[m - k, j] = k; // i == m - 1
            }
            for (int i = k - 1; i <= m - k; i++)
            {
                res[i, k - 1] = k; // j == 0
                res[i, n - k] = k; // j == n - 1
            }
        }
        return res;
    }
}
