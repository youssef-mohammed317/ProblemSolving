using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class TotalAmountOfPoints
{
    public static int TotalPoints(string[] games)
    {
        int totalPoints = 0;
        foreach (var g in games)
        {
            if (g[0] > g[2])
            {
                totalPoints += 3;
            }
            else if (g[0] == g[2])
            {
                totalPoints++;
            }
        }
        //games.Sum(s => s[0] < s[2] ? 0 : s[0] == s[2] ? 1 : 3);
        return totalPoints;
    }
}
