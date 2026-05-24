using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Algorithms;

internal class Collatz_Conjecture_3n_1
{
    public static uint Hotpo(uint n)
    {
        if (n == 1)
            return 0;
        return Hotpo(n % 2 == 0 ? n / 2 : 3 * n + 1) + 1;
    }
}
