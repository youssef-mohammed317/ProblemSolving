using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class UEFA_EURO_2016
{
    public static string UefaEuro2016(string[] teams, int[] scores)
    {
        return $"At match {teams[0]} - {teams[1]}, {(scores[0] == scores[1] ? "teams played draw." : $"{(scores[0] > scores[1] ? teams[0] : teams[1])} won!")}";
    }
}
