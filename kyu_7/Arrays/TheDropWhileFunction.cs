using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class TheDropWhileFunction
{
    public static int[] DropWhile(int[] arr, Func<int, bool> pred)
    {
        int j = 0;
        while (j < arr.Length && pred.Invoke(arr[j]))
            j++;

        //return arr.Skip(j).ToArray();
        //return arr.SkipWhile(pred).ToArray();
        return arr[j..];
    }
}
