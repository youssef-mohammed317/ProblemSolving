using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Find_the_middle_element
{
    public static int Gimme(double[] inputArray)
    {

        return Array.IndexOf(inputArray, inputArray.OrderBy(x => x).ToArray()[inputArray.Length / 2]);
    }
}
