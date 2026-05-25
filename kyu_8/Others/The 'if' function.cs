using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Others;

internal class The__if__function
{
    public static void If(bool condition, Action func1, Action func2)
    {
        if (condition)
        {
            func1.Invoke();
        }
        else
        {
            func2.Invoke();
        }
    }
}
