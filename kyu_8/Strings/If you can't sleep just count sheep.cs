using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Strings;

internal class If_you_can_t_sleep_just_count_sheep
{
    public static string CountSheep(int n)
    {
        return string.Join("",Enumerable.Range(1, n).Select(x => $"{x} sheep..."));
    }
}
