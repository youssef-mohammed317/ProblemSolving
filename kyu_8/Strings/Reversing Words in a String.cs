using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Strings;

internal class Reversing_Words_in_a_String
{
    public static string Reverse(string text)
    {
        return string.Join(" ", text.Split(" ").Reverse());
    }
}
