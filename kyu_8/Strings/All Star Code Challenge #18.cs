using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Strings;

internal class All_Star_Code_Challenge__18
{
    public static int StrCount(string str, char letter)
    {
        return str.Count(c => c == letter);
    }
}
