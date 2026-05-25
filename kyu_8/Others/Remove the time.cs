using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Others;

internal class Remove_the_time
{
    public static string ShortenToDate(string longDate)
    {
        var str = longDate.Split(" ");
        return $"{str[0]} {str[1]} {str[2].Replace(",", "")}";
    }

}
