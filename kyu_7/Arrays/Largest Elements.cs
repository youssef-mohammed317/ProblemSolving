using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Largest_Elements
{
    public static List<int> Largest(int n, List<int> xs)
    {
        // Find the n highest elements in a list
        return xs.OrderBy(x => x).TakeLast(n).ToList();
    }
}
