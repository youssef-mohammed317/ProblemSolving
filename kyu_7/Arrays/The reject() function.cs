using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class The_reject___function
{
    public static int[] Reject(int[] array, Func<int, bool> predicate)
    {
        //return array.Where(i => !predicate(i)).ToArray();
        return array.Except(array.Where(predicate)).ToArray();
    }
}
