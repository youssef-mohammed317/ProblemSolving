using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Mathematics;

internal class Localize_The_Barycenter_of_a_Triangle
{
    public static double[] BarTriang(double[] x, double[] y, double[] z)
    {
        return new double[] { Math.Round((x[0] + y[0] + z[0]) / 3, 4), Math.Round((x[1] + y[1] + z[1]) / 3, 4) };
    }
}
