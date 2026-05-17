using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_6.Array;

internal class SumOfDigits_DigitalRoot
{
    public static int DigitalRoot(long n)
    {
        if (n / 10 == 0) return (int)n;

        long val = n.ToString().Select(d => (long)(d - '0')).Sum();

        return DigitalRoot(val);
    }
}
