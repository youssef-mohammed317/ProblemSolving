using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

/*
You will be given an array a and a value x. All you need to do is check whether the provided array contains the value.

a can contain numbers or strings. x can be either.

Return true if the array contains the value, false if not.
 */
internal class YouOnlyNeedOneBeginner
{
    public static bool Check(object[] a, object x)
    {
        //foreach (var t in a)
        //{
        //    if (t.Equals(x)) return true;
        //}
        return a.Contains(x);
    }
}
