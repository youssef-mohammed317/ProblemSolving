using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Mathematics;

internal class Even_or_Odd
{
    public static string EvenOrOdd(int number)
    {
        return number % 2 == 0 ? "Even" : "Odd";
    }
}
