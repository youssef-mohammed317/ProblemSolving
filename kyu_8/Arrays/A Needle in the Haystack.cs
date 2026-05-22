using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class A_Needle_in_the_Haystack
{
    public static string FindNeedle(object[] haystack)
    {
        return $"found the needle at position {Array.IndexOf(haystack, "needle")}";
    }
}
