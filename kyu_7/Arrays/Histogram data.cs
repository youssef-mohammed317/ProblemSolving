using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Histogram_data
{
    public static uint[] Histogram(uint[] data, uint binWidth)
    {
        if (data.Length == 0) return [];
        Array.Sort(data);
        uint[] histogram = new uint[data[^1] / binWidth + 1];
        uint k = 0, i = 0, j = binWidth, counter = 0;
        while (k < histogram.Length)
        {
            counter = 0;
            while (i < data.Length && data[i] < j)
            {
                counter++;
                i++;
            }
            histogram[k++] = counter;
            j += binWidth;
        }
        return histogram;
    }
}
