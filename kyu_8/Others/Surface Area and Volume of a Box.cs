using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Others;

internal class Surface_Area_and_Volume_of_a_Box
{
    public static int[] Get_size(int w, int h, int d)
    {
        return [2 * (w * h + w * d + h * d), w * h * d];
    }
}
