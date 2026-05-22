using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class Add_Length
{
    public static string[] AddLength(string str)
    {
        return str.Split(' ').Select(x => $"{x} {x.Length}").ToArray();
    }
}
