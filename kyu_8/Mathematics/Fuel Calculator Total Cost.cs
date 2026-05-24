using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Mathematics;

internal class Fuel_Calculator_Total_Cost
{
    public static double FuelPrice(double litres, double pricePerLitre)
    {
        return Math.Round(litres * (pricePerLitre - Math.Min(0.25, (int)(litres / 2) * 0.05)), 2);
    }
}
