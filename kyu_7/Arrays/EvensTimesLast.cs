using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class EvensTimesLast
{
    public static int EvenTimesLast(int[] arr)
    {
        //int sum = 0;
        //for (int i = 0; i < arr.Length; i += 2)
        //{
        //    sum += arr[i] * arr[arr.Length - 1];
        //}
        //return sum;
        return arr.Where((a, i) => i % 2 == 0).Sum(c => c * arr.LastOrDefault());

    }
}
