using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Strings;

internal class Name_Shuffler
{
    public static string NameShuffler(string str)
    {
        return string.Join(" ", str.Split(" ").Reverse());
    }
}
