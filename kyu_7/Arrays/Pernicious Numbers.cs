using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Pernicious_Numbers
{
    public static bool IsPrime(int n)
    {
        if (n == 1) return false;
        if (n == 2) return true;
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }
    public static object Pernicious(double n)
    {
        if (n < 1) return "No pernicious numbers";
        var res = Enumerable.Range(1, (int)n).Where(num => IsPrime(Convert.ToString(num, 2).Count(x => x == '1')));
        return res.Any() ? res.ToArray() : "No pernicious numbers";
    }
}
