using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class FirstNonConsecutiveNumber
{
    public static object? FirstNonConsecutive(int[] arr)
    {
        var res = arr.Where((x, i) => i > 0 && x > 1 + arr[i - 1]);
        return res.Any() ? res.FirstOrDefault() : null;
    }
}
