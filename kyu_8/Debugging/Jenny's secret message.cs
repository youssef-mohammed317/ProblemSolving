using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Debugging;

internal class Jenny_s_secret_message
{
    public static string greet(string name)
    {
        if (name == "Johnny")
            return "Hello, my love!";
        return "Hello, " + name + "!";
    }
}
