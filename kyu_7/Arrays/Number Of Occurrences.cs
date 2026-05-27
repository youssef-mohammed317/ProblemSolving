using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Number_Of_Occurrences
{
    public static int NumberOfOccurrences(int x, int[] xs)
    {
        return xs.Count(n => x == n);
    }
}
