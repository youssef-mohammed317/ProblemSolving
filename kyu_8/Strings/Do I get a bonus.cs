using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Strings;

internal class Do_I_get_a_bonus
{
    public static string bonus_time(int salary, bool bonus)
    {
        return $"${(bonus ? (salary * 10).ToString() : salary.ToString())}";
    }
}
