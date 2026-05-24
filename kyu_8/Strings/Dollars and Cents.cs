using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Strings;

internal class Dollars_and_Cents
{
    public static string FormatMoney(double amount)
    {
        int  amu = (int) Math.Round((amount * 100));

        return $"${amu / 100}.{(amu / 10) % 10}{amu % 10}";
    }
}
