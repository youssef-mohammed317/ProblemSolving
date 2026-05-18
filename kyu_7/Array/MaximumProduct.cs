using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Array;

internal class MaximumProduct
{
    public static int AdjacentElementsProduct(int[] array)
    {
        int maxMul = int.MinValue;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] * array[i - 1] > maxMul)
            {
                maxMul = array[i] * array[i - 1];
            }
        }
        return maxMul;
        //return array.Skip(1).Select((x, i) => x * array[i]).Max();
    }
}
