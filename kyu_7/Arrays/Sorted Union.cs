using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Sorted_Union
{
    public static object[] UniteUnique(object[][] array)
    {
        return array.SelectMany(x => x).GroupBy(x => x).Select(kv => kv.Key).ToArray();
    }
}
