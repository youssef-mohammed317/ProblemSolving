using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Mathematics;

internal class Holiday_VI___Shark_Pontoon
{
    public static string Shark(
      int pontoonDistance,
      int sharkDistance,
      int youSpeed,
      int sharkSpeed,
      bool dolphin)
    {
        if (dolphin) sharkSpeed /= 2;

        return pontoonDistance * sharkSpeed <= sharkDistance * youSpeed ? "Alive!" : "Shark Bait!";
    }
}
