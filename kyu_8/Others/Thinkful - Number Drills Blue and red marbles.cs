using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Others;

internal class Thinkful___Number_Drills_Blue_and_red_marbles
{
    public static double GuessBlue(uint blueStart, uint redStart, uint bluePulled, uint redPulled)
    {
        return Math.Round((double)(blueStart - bluePulled) / (blueStart - bluePulled + redStart - redPulled), 1);
    }
}
