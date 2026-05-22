using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class Invert_values
{
    public static int[] InvertValues(int[] input)
    {
        return input.Select(x => x * -1).ToArray();
    }
}
