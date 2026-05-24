using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Strings;

internal class The_Wide_Mouthed_frog_
{
    public static string MouthSize(string animal)
    {
        return animal.ToLower() == "alligator" ? "small" : "wide";
    }
}
