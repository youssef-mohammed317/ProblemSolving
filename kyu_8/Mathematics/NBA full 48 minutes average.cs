using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Mathematics;

internal class NBA_full_48_minutes_average
{
    public static double NbaExtrap(double ppg, double mpg)
    {
        if (mpg == 0 || ppg == 0) return 0;
        return Math.Round(ppg / mpg * 48, 1);
    }
}
