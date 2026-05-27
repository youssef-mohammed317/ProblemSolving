using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Filter_Coffee
{
    public static string Search(int budget, int[] prices)
    {
        // return array pf prices that are within budget
        return string.Join(",", prices.OrderBy(x => x).Where(x => x <= budget));
    }
}
