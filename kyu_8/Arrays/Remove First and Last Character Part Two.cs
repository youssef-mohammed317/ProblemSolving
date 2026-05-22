using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class Remove_First_and_Last_Character_Part_Two
{
    public static string? Array(string s)
    {
        var strarr =  s.Split(",").Skip(1).SkipLast(1).ToArray();
        return strarr.Length < 1 ? null : string.Join(" ", strarr);
    }
}