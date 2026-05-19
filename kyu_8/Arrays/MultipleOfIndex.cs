using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class MultipleOfIndex
{
    public static List<int> MultipleOfInde(List<int> xs)
    {
        //return xs.Where((n, i) => i == 0 ? n == 0 : n % i == 0).ToList();
        return xs.Where((x, i) => (i == 0 && x == 0) || (i != 0 && x % i == 0)).ToList();
    }
}
