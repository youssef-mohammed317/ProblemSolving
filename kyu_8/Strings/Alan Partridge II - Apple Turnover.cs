using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Strings;

internal class Alan_Partridge_II___Apple_Turnover
{
    public static string Apple(object n)
    {
        int val = int.Parse(n.ToString());
        return val * val > 1000 ? "It's hotter than the sun!!" : "Help yourself to a honeycomb Yorkie for the glovebox.";
    }
}
