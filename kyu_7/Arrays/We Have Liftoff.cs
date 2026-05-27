using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class We_Have_Liftoff
{
    public static string Liftoff(List<int> instructions)
    {
        return $"{string.Join(" ", instructions.OrderByDescending(x => x))} liftoff!";
    }
}
