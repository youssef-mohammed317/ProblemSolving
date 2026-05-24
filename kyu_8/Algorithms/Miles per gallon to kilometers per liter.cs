using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Algorithms;

internal class Miles_per_gallon_to_kilometers_per_liter
{
    public static double Converter(int mpg)
    {
        return Math.Round(mpg * 1.609344 / 4.54609188, 2);
    }
}
