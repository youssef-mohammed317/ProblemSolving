using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class pick_a_set_of_first_elements
{
    public static object[] TakeFirstElements(object[] array, int n = 1)
    {
        return array.Take(n).ToArray();
    }
}
