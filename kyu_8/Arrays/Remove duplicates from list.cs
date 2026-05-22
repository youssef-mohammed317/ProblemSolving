using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class Remove_duplicates_from_list
{
    public static int[] distinct(int[] a)
    {
        return a.Distinct().ToArray();
    }
}
