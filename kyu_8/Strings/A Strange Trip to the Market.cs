using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Strings;

internal class A_Strange_Trip_to_the_Market
{
    public static bool IsLockNessMonster(string sentence)
    {
        return sentence.Contains("tree fiddy",StringComparison.OrdinalIgnoreCase) || sentence.Contains("3.50");
    }
}
