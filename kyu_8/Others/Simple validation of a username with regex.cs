using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace kyu_8.Others;

internal class Simple_validation_of_a_username_with_regex
{
    public static bool ValidateUsr(string username)
    {
        return Regex.IsMatch(username, @"^[a-z_0-9]{4,16}$");
    }
}
