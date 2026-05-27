using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Fizz_Buzz
{
    public static string[] GetFizzBuzzArray(int n)
    {
        return Enumerable.Range(0, n).Select(x => x % 3 == 0 && x % 5 == 0 ? "FizzBuzz" : x % 3 == 0 ? "Fizz" : x % 5 == 0 ? "Buzz" : $"{x}").ToArray();
    }
}
