using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Insert_dashes
{
    public bool IsOdd(int n) => n % 2 != 0;
    public static string InsertDash(int num)
    {
        string res = "";
        while (num > 0)
        {
            res += num % 10;
            if ((num % 10) % 2 != 0 && num / 10 > 0 && (((num / 10) % 10 % 2 != 0)))
                res += "-";
            num /= 10;
        }
        return string.Concat(res.Reverse());
    }
}
