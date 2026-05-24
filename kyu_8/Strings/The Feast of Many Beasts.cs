using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Strings;

internal class The_Feast_of_Many_Beasts
{
    public static bool Feast(string beast, string dish)
    {
        return beast.FirstOrDefault() == dish.FirstOrDefault() && beast.LastOrDefault() == dish.LastOrDefault();
        //return beast[0] == dish[0] && beast[^1] == dish[^1];
        //return dish.StartsWith(beast[0]) && dish.EndsWith(beast[beast.Length - 1]);

    }
}
