using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Strings;

internal class Double_Char
{
    public static string DoubleChar(string s)
    {
        return string.Concat(s.Select(x => $"{x}{x}"));
    }
}
