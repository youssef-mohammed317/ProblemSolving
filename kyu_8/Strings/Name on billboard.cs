using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Strings;

internal class Name_on_billboard
{
    public static double Billboard(string name, double price = 30)
    {
        return name.Sum(x => price);
    }
}
