using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Algorithms;

internal class Pirates___Are_the_Cannons_ready
{
    public static string CannonsReady(Dictionary<string, string> gunners)
    {
        return gunners.Where(kv => kv.Value == "nay").Any() ? "Shiver me timbers!" : "Fire!";
        //return gunners.ContainsValue("nay") ? "Shiver me timbers!" : "Fire!";

    }
}
