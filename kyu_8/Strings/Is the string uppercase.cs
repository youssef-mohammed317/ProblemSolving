using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Strings;

internal class Is_the_string_uppercases
{
    public static bool IsUpperCase( string text)
    {
        return !text.SkipWhile(x => char.IsUpper(x) || char.IsWhiteSpace(x)).Any();
        //return value.ToUpper() == value;

    }
}
