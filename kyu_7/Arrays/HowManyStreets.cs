using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class HowManyStreets
{
    public static int[] CountStreets(string[] streets, string[][] drivers)
    {
        Dictionary<string, int> streetIndex = new Dictionary<string, int>();
        for (int s = 0; s < streets.Length; s++)
        {
            streetIndex[streets[s]] = s;
        }


        int[] result = new int[drivers.Length];

        for (int d = 0; d < drivers.Length; d++)
        {
            int start = streetIndex[drivers[d][0]];
            int end = streetIndex[drivers[d][1]];

            result[d] = Math.Abs(end - start) - 1;
        }

        return result;
    }
}
