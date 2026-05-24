using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Strings;

internal class String_repeat
{
    public static string RepeatStr(int n, string s)
    {
        return string.Join("", Enumerable.Range(1, n).Select(x => s));
        //return string.Concat(Enumerable.Repeat(s, n));

    }
}
