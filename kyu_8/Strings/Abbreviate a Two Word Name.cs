using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Strings;

internal class Abbreviate_a_Two_Word_Name
{
    public static string AbbrevName(string name)
    {
        return string.Join(".", name.Split(" ").Select(x => char.ToUpper(x[0])));
    }
}
