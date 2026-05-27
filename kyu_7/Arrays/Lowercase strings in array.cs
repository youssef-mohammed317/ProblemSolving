using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Lowercase_strings_in_array
{
    public static object[] ArrayLowerCase(object[] arr)
    {
        return arr.Select(x => (x is string s) ? s.ToLower() : x).ToArray();
    }
}
