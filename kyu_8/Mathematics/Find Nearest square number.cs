using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Mathematics;

internal class Find_Nearest_square_number
{
    public static int NearestSq(int n)
    {
        var sqrt = Math.Sqrt(n);
        var up = Math.Ceiling(sqrt);
        var down = Math.Floor(sqrt);
        up *= up;
        down *= down;
        return (int)(Math.Abs(up - n) > Math.Abs(down - n) ? down : up);
    }
}
