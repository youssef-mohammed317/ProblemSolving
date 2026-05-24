using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Strings;

internal class Exclamation_marks_series__1_Remove_an_exclamation_mark_from_the_end_of_string
{
    public static string Remove(string s)
    {
        return s[^1] == '!' ? s.Substring(0, s.Length - 1):s;
        //return s.EndsWith("!") ? s.Remove(s.Length - 1) : s;

    }
}
