using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Others;

internal class Count_the_number_of_cubes_with_paint_on
{
    public static int CountSquares(int cuts)
    {
        if (cuts == 0) return 1;
        return (cuts + 1) * (cuts + 1) * (cuts + 1) - (cuts - 1) * (cuts - 1) * (cuts - 1);
    }
}
