using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class Convert_number_to_reversed_array_of_digits
{
    public static long[] Digitize(long n)
    {
        long[] res = new long[n.ToString().Length];
        int i = 0;
        while (n > 0)
        {
            res[i] = n % 10;
            n = n / 10;
            i++;
        }
        return res;
    }
}
