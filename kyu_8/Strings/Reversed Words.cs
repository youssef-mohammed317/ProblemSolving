using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Strings;

internal class Reversed_Words
{
    public static string ReverseWords(string str)
    {
        return string.Join(" ", str.Split(" ").Reverse());
    }
}
