using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Smallest_value_of_an_array
{
    public static int FindSmallest(int[] numbers, string mode)
    {
        return mode == "value" ? numbers.Min() : Array.IndexOf(numbers, numbers.Min());
    }
}
