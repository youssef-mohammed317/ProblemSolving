using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class Filter_out_the_geese
{
    public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
    {
        // return IEnumerable of string containing all of the strings in the input collection, except those that match strings in geese
        string[] geese = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };

        //return birds.Except(geese);
        return birds.Where(str => !geese.Contains(str));
    }
}
