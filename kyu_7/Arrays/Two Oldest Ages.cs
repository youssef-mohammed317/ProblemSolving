using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Two_Oldest_Ages
{
    public static int[] TwoOldestAges(int[] ages)
    {
        return ages.OrderByDescending(a => a).Take(2).Reverse().ToArray();
    }
}
