using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Debugging;

internal class Is_this_my_tail
{
    public static bool CorrectTail(string body, string tail)
    {
        string sub = body.Substring(body.Length - 1);

        if (sub == tail)
            return true;
        else
            return false;
    }
}
