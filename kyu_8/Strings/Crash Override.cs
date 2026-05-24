using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Strings;

internal class Crash_Override
{
    static Dictionary<string,string> FirstName, Surname;
    //FirstName = {{"A", "Alpha"}, {"B", "Beta"}, {"C", "Cache"}, ...}
    //Surname = {{"A", "Analogue"}, {"B", "Bomb"}, {"C", "Catalyst"} ...}
    public static string AliasGen(string fName, string lName)
    {
        // class is partial,
        // FirstName and Surname dictionaries are defined in other part of partial
        // you can access them directly here

        return char.IsLetter(fName[0]) && char.IsLetter(lName[0]) ?
        FirstName[char.ToUpper(fName[0]).ToString()] + " " + Surname[char.ToUpper(lName[0]).ToString()] :
        "Your name must start with a letter from A - Z.";
    }
}
