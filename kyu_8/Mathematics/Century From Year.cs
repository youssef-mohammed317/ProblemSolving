using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Mathematics;

internal class Century_From_Year
{
    public static int СenturyFromYear(int year)
    {
        return (int)Math.Ceiling((double)year / 100.0);
    }
}
