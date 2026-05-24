using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Mathematics;

internal class Simple_Fun__1_Seats_in_Theater
{
    public static int SeatsInTheater(int nCols, int nRows, int col, int row)
    {
        return (nRows - row) * (nCols - col + 1);
    }
}
