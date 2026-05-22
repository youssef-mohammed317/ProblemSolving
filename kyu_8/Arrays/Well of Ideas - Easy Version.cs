using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class Well_of_Ideas___Easy_Version
{
    public static string Well(string[] x)
    {
        var count = x.Count(a => a == "good");
        return count > 2 ? "I smell a series!" : count > 0 ? "Publish!" : "Fail!";
    }
}
