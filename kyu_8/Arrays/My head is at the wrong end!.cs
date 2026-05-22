using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class My_head_is_at_the_wrong_end_
{
    public static string[] FixTheMeerkat(string[] arr)
    {
        return arr.Reverse().ToArray();
    }
}
