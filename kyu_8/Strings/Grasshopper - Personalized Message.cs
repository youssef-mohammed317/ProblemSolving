using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Strings;

internal class Grasshopper___Personalized_Message
{
    public static string Greet(string name, string owner)
    {
        return name == owner ? "Hello boss" : "Hello guest";
    }
}
