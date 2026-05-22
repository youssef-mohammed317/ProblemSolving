using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class Printing_Array_elements_with_Comma_delimiters
{
    public static string PrintArray(object[] array)
    {
        return string.Join(",", array.SelectMany(x => x is object[] arr ? arr : [x]).ToArray());
    }
}
