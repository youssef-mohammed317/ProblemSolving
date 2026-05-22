using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class Enumerable_Magic_1___True_for_All
{
    public static bool All(int[] arr, Func<int, bool> fun)
    {
        return arr.All(fun);
    }
}
