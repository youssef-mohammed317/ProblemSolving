using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class Count_the_Monkeys_
{
    public static int[] MonkeyCount(int n)
    {
    
        return Enumerable.Range(1, n).ToArray();
    }
}
