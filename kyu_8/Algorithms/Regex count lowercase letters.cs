using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Algorithms;

internal class Regex_count_lowercase_letters
{
    public static int LowercaseCountCheck(string s)
    {
        return s.Count(c => char.IsLower(c));
    }
}
