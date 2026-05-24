using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Debugging;

internal class Case___Bug_Fixing__6
{
    public static double EvalObject(double value1, double value2, char operation)
    {
        double result = 0;
        switch (operation)
        {
            case '+': result = value1 + value2; break;
            case '-': result = value1 - value2; break;
            case '/': result = value1 / value2; break;
            case '*': result = value1 * value2; break;
            case '%': result = value1 % value2; break;
            case '^': result = Math.Pow(value1, value2); break;
        }
        return result;
    }
}
