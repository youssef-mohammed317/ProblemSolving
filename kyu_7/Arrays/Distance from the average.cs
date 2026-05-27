using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Distance_from_the_average
{
    public static double[] DistancesFromAverage(int[] input)
    {
        double avg = input.Average();

        return input.Select(x => Math.Round(avg - x, 2)).ToArray();
    }
}
