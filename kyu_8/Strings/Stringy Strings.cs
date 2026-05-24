using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Strings;

internal class Stringy_Strings
{
    public static string Stringy(int size)
    {
        return string.Concat(Enumerable.Range(1, size).Select(x => x % 2 == 0 ? "0" : "1"));
    }
}
