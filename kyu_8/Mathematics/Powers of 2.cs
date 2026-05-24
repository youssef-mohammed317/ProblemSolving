using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Mathematics;

internal class Powers_of_2
{
    public static BigInteger[] PowersOfTwo(int n)
    {
        var res = new BigInteger[n + 1];
        for (int i = 0; i <= n; i++)
        {
            res[i] = new BigInteger(Math.Pow(2, i));
        }
        return res;
    }
}
