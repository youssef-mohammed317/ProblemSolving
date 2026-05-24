using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Mathematics;

internal class Basic_Mathematical_Operations
{
    public static double basicOp(char operation, double value1, double value2)
    {
        return operation switch
        {
            '+' => value1 + value2,
            '-' => value1 - value2,
            '/' => value1 / value2,
            _ => value1 * value2
        };
    }
}
