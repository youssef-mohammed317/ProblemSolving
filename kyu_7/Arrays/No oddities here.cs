using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class No_oddities_here
{
    public static int[] NoOdds(int[] values)
    {
        return values.Where(x => x % 2 == 0).ToArray();
    }
}
