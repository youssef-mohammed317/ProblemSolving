using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class Removing_Elements
{
    public static object[] RemoveEveryOther(object[] arr)
    {
        return arr.Where((x, i) => (i + 1) % 2 != 0).ToArray();
    }
}
