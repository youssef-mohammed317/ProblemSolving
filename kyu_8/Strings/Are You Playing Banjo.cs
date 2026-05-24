using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Strings;

internal class Are_You_Playing_Banjo
{
    public static string AreYouPlayingBanjo(string name)
    {
        return name.StartsWith("r", StringComparison.OrdinalIgnoreCase) ? $"{name} plays banjo" : $"{name} does not play banjo";
    }
}
