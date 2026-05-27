using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Partial_Word_Searching
{
    public static string[] WordSearch(string query, string[] seq)
    {
        var res = seq.Where(str => str.Contains(query, StringComparison.InvariantCultureIgnoreCase)).ToArray();
        return res.Any() ? res : ["Empty"];
    }
}
