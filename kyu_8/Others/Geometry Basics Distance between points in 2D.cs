using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Others;


internal class Geometry_Basics_Distance_between_points_in_2D
{
    public static double DistanceBetweenPoints(Point a, Point b)
    {
        return Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
    }
}
