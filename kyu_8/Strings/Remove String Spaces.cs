using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Strings;

internal class Remove_String_Spaces
{
    public static string NoSpace(string input)
    {
        return string.Join("", input.Where(x => x != ' '));
        //return input.Replace(" ", "");

    }
}
