using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace kyu_8.Others;

internal class validate_code_with_simple_regex
{
    public static bool ValidateCode(string code)
    {
        return Regex.IsMatch(code, @"^[1-3]\d*");
    }
}
