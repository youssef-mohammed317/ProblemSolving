using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Retrieve_array_value_by_index_with_default
{
    public static int Solution(int[] items, int index, int defaultValue)
    {
        return Math.Abs(index) > items.Length ? defaultValue : (index >= 0 ? items[index] : items[^(-index)]);
    }
}
