using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace kyu_8.Strings;

internal class String_cleaning
{
    public static string StringClean(string s)
    {
        return string.Join("", s.Where(x => x < '0' || x > '9'));
        //Regex.Replace(s, @"\d", "")
        //return String.Join("", s.Where(x => !Char.IsDigit(x)));


    }
}
