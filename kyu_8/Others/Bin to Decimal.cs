using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Others;

internal class Bin_to_Decimal
{
    public static int binToDec(string s)
    {
        int res = 0;
        for (int i = 1; i <= s.Length; i++)
        {
            if (s[^i] == '1')
                res += (int)Math.Pow(2, i - 1);
        }
        return res;
    }
}
