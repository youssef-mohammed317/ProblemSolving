using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Mathematics;

internal class Evil_or_Odious
{
    public static string Evil(int n)
    {
        int ones = 0;
        while (n > 0)
        {
            if (n % 2 == 1) ones++;
            n /= 2;
        }

        return ones % 2 == 0 ? "It's Evil!" : "It's Odious!";
    }
}
