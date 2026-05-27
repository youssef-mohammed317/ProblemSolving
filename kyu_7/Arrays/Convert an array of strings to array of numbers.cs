using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Convert_an_array_of_strings_to_array_of_numbers
{
    public static double[] ToDoubleArray(string[] stringArray)
    {
        return stringArray.Select(x => double.Parse(x)).ToArray();
    }
}
