using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Others;

internal class Is_your_period_late
{
    public static bool PeriodIsLate(DateTime last, DateTime today, int cycleLength)
    {
        return last.AddDays(cycleLength) < today;
    }
}
