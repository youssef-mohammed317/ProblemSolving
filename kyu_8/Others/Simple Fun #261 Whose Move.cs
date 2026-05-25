using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Others;

internal class Simple_Fun__261_Whose_Move
{
    public static string WhoseMove(string lastPlayer, bool win)
    {
        return win ? lastPlayer : (lastPlayer == "white" ? "black" : "white");
    }
}
