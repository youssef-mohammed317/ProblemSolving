using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Strings;

internal class Correct_the_mistakes_of_the_character_recognition_software
{
    public static string Correct(string text)
    {
        return text.Replace("0", "O").Replace("5", "S").Replace("1", "I");
    }
}
