using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Algorithms;

internal class Draw_stairs
{
    public static string DrawStairs(int n)
    {
        return string.Concat(Enumerable.Range(1, n).Select(x => $"{(x > 1 ? "\n" + string.Concat(Enumerable.Range(1, x -1).Select(y => " ")) : "")}I"));
        //return string.Join("\n ", Enumerable.Repeat("I", n).Select((s, i) => s.PadLeft(i)));
        //return string.Join('\n', Enumerable.Range(1, n).Select("I".PadLeft));


    }
}
