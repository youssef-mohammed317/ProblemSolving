using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Testing_1_2_3
{
    public static List<string> Number(List<string> lines)
    {
        return lines.Select((l, i) => $"{(i + 1)}: {l}").ToList();
    }
}
