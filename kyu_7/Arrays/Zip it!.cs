using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Zip__it_
{
    public static object[] ZipIt(object[] a, object[] b, Func<object, object, object> fn)
    {
        return Enumerable.Range(0, Math.Min(a.Length, b.Length)).Select(x => fn(a[x], b[x])).ToArray();
    }
}
