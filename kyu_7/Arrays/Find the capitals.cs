using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Find_the_capitals
{
    public static int[] Capitals(string word)
    {
        return word.Select((c, i) => new { selected = char.IsUpper(c), pos = i }).Where(p => p.selected).Select(p => p.pos).ToArray();
    }
}
