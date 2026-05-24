using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Strings;

internal class Short_Long_Short
{
    public static string Solution(string a, string b)
    {
        return a.Length > b.Length ? $"{b}{a}{b}" : $"{a}{b}{a}";
    }
}
