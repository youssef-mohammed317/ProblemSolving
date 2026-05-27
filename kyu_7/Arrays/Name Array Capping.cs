using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Name_Array_Capping
{
    public static string[] CapMe(string[] strings)
    {
        return strings.Select(x => $"{char.ToUpper(x[0])}{x.ToLower().Substring(1)}").ToArray();
    }
}
