using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Algorithms;

internal class Heads_and_Legs
{
    public static object Animals(int heads, int legs)
    {
        var cows = (legs - 2 * heads) / 2;
        var chickens = heads - cows;
        return cows >= 0 && chickens >= 0 && cows + chickens == heads && cows * 4 + chickens * 2 == legs ? new int[] { chickens, cows } : "No solutions";
    }
}
