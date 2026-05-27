using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class First_Class_Function_Factory
{
    public static Func<int[], int[]> factory(int x)
    {
        Func<int[], int[]> res = (arr) => arr.Select(n => n * x).ToArray();
        return res;
    }
}
