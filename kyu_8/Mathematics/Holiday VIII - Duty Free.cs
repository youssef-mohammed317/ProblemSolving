using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Mathematics;

internal class Holiday_VIII___Duty_Free
{
    public static int DutyFree(int normPrice, int Discount, int hol)
    {
        return (int)(hol / (normPrice * (double)(100 - Discount) / 100));
    }
}
