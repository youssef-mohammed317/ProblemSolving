using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Debugging;

internal class Get_Planet_Name_By_ID
{
    public static string GetPlanetName(int id)
    {
        string name = "";
        switch (id)
        {
            case 1:
                name = "Mercury"; break;
            case 2:
                name = "Venus"; break;
            case 3:
                name = "Earth"; break;
            case 4:
                name = "Mars"; break;
            case 5:
                name = "Jupiter"; break;
            case 6:
                name = "Saturn"; break;
            case 7:
                name = "Uranus"; break;
            case 8:
                name = "Neptune"; break;
        }

        return name;
    }
}
