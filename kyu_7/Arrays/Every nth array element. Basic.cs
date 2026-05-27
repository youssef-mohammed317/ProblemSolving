using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Every_nth_array_element
{
    public static IEnumerable<T> Every<T>(IEnumerable<T> arr, int interval, int start)
    {
        return arr.Where((x, i) => i >= start && (i - start) % interval == 0);
    }

    public static IEnumerable<T> Every<T>(IEnumerable<T> arr, int interval)
    {
        return arr.Where((x, i) => i % interval == 0);
    }

    public static IEnumerable<T> Every<T>(IEnumerable<T> arr)
    {
        return arr;
    }
}
