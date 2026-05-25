using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Others;

internal class L1_Set_Alarm
{
    public static bool SetAlarm(bool employed, bool vacation)
    {
        return employed && !vacation;
    }
}
