using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class Take_an_Arrow_to_the_knee_Functionally
{
    public static string ArrowFunc(int[] arr)
    {
        return string.Join("", arr.Select(n => (char)n).ToArray());
    }
}
