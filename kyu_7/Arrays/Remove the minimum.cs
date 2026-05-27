using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Remove_the_minimum
{
    public static List<int> RemoveSmallest(List<int> numbers)
    {
        if (numbers.Any())
            numbers.Remove(numbers.Min());
        return numbers;
    }
}
