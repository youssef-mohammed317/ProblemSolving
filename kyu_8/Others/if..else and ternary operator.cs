using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Others;

internal class Training_JS___if__else_and_ternary_operator
{
    public static int SaleHotDogs(int n)
    {
        return n * (n < 5 ? 100 : n >= 10 ? 90 : 95);
    }
}
