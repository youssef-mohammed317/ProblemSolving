using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Mathematics;

internal class Pole_Vault_Starting_Marks
{
    public static double StartingMark(double bodyHeight)
    {
        // Remember: Body height of 1.52 m --> starting mark: 9.45 m
        //           Body height of 1.83 m --> starting mark: 10.67 m
        // All other starting marks are based on these guidelines!

        return Math.Round(10.67 - (1.83 - bodyHeight) * ((10.67 - 9.45) / (1.83 - 1.52)), 2);
    }
}
