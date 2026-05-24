using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Strings;

internal class Contamination__1__String_
{
    public static string Contamination(string text, string character)
    {
        return string.Join("", text.Select(x => character));
    }
}
