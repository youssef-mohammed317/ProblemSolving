using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Strings;

internal class Multiplication_table_for_number
{
    public static string MultiTable(int number)
    {
        return string.Join("\n",Enumerable.Range(1,10).Select(x => $"{x} * {number} = {x*number}"));
    }
}
