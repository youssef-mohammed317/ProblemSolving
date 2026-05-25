using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace kyu_8.Others;

internal class Regexp_Basics___is_it_a_digit
{
    public static bool Digit(string s)
    {
        return Regex.Match(s, @"^\d{1}\z").Success;
    }
}
