using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Product_of_Largest_Pair
{
    public static int MaxProduct(int[] array)
    {
        int max1 = 0, max2 = 0;
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[max1])
            {
                max1 = i;
            }
        }
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[max2] && max1 != i)
            {
                max2 = i;
            }
        }

        return array[max2] * array[max1];
    }
}
