using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class How_many_stairs_will_Suzuki_climb_in_20_years
{
    public static long StairsIn20(int[][] stairs)
    {
        return stairs.SelectMany(s => s).Sum() * 20;
    }
}
