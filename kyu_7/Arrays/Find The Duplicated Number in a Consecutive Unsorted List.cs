using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Find_The_Duplicated_Number_in_a_Consecutive_Unsorted_List
{
    public static int FindDup(int[] arr)
    {
        return arr.OrderBy(x => x).SkipWhile((x, i) => x == i + 1).FirstOrDefault();
    }
}
