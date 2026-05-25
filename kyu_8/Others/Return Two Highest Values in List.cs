using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Others;

internal class Return_Two_Highest_Values_in_List
{
    public static int[] TwoHighest(int[] arr)
    {
        if (arr.Length == 0) return [];
        int max = arr.Max();
        int max2 = arr.Any(x => x < max) ? arr.Where(x => x < max).Max() : max;
        if (max == max2) return [max];
        return new int[] { max, max2 };
    }
}
