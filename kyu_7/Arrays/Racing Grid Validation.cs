using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Racing_Grid_Validation
{
    public static bool ValidateRace(int[] moves)
    {

        return moves.Select((m, i) => i + m).OrderBy(x => x).SequenceEqual(Enumerable.Range(0, moves.Length - 1));
    }
}
