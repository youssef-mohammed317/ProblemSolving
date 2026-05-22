using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class Find_numbers_which_are_divisible_by_given_number
{
    public static int[] DivisibleBy(int[] numbers, int divisor)
    {
        return numbers.Where(x => x % divisor == 0).ToArray();
  }
}
