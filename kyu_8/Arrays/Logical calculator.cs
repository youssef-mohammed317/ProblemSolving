using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class Logical_calculator
{
    public static bool LogicalCalc(bool[] array, string op)
    {
        if (op == "AND")
        {
            return !array.Any(a => !a);
        }
        else if (op == "OR")
        {
            return array.Any(a => a);
        }
        else
        {
            // "XOR"
            return array.Count(a => a) % 2 != 0;
        }
        
    }
}
