using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class Swap_Values
{
    public object[] Arguments { get; private set; }

    public Swap_Values(ref object[] args)
    {
        Arguments = args;
    }

    public void SwapValues()
    {
        object[] args = Arguments;

        object temp = args[0];
        args[0] = args[1];
        args[1] = temp;
    }
}
