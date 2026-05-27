using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Sum_of_two_lowest_positive_integers
{
    public static int sumTwoSmallestNumbers(int[] numbers)
    {
        return numbers.OrderBy(x => x).Take(2).Sum();

    }
}
