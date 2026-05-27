using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Ones_and_Zeros
{
    public static int binaryArrayToNumber(int[] BinaryArray)
    {
        int res = 0;
        for (int j = BinaryArray.Length - 1; j >= 0; j--)
        {
            if (BinaryArray[j] == 1)
                res += (int)Math.Pow(2, BinaryArray.Length - j - 1);
        }
        return res;
        //return Convert.ToInt32(string.Join("", BinaryArray), 2);
    }
}
