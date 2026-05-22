using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class Count_of_positives__sum_of_negatives
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
        return input != null && input.Any() ? [input.Count(x => x > 0), input.Sum(x => x < 0 ? x : 0)] : [];
    }
}
