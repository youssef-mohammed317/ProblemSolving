using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Others;

public class Circle
{
    public Point Center { get; private set; }
    public double Radius { get; private set; }

    public Circle(Point center, double radius)
    {
        this.Center = center;
        this.Radius = radius;
    }
}
internal class Geometry_Basics_Circle_Area_in_2D
{
    public static double CircleArea(Circle circle)
    {
        return Math.PI * circle.Radius * circle.Radius;
    }
}
