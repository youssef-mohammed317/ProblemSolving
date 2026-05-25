using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Others;

internal class Triple_Trouble
{
    public static string TripleTrouble(string one, string two, string three)
    {
        return string.Concat(one.Select((c, i) => $"{c}{two[i]}{three[i]}"));
    }
}
