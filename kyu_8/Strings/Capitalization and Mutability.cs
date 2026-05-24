using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Strings;

internal class Capitalization_and_Mutability
{
    public static string CapitalizeWord(string word)
    {
        return word.ToUpper()[0] + word.Substring(1);
    }
}
