using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Algorithms;

internal class Convert_to_Binary
{
    public static int ToBinary(int n)
    {
        int res = 0, i = 1;
        while (n > 0)
        {
            res += (n % 2) * i;
            n /= 2;
            i *= 10;
        }
        return res;

        //return Convert.ToInt32(Convert.ToString(n, 2));

    }
}
