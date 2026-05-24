using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Strings;

internal class String_Templates___Bug_Fixing_5
{
    public static string buildString(string[] args)
    {
        return $"I like {string.Join(", ", args)}!";
    }
}
