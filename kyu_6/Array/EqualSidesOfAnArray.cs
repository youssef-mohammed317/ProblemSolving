using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_6.Array;

internal class EqualSidesOfAnArray
{
    public static int FindEvenIndex(int[] arr)
    {
        //for (int start = 0; start < arr.Length; start++)
        //{
        //    int sumleft = arr.Take(start).Sum();
        //    int sumRight = arr.Skip(start).Sum();
        //    if (sumleft == sumRight)
        //        return start;
        //}
        int totalSum = arr.Sum();
        int leftSum = 0, rightSum;
        for (int start = 0; start < arr.Length; start++)
        {
            rightSum = totalSum - leftSum - arr[start];

            if (rightSum == leftSum)
                return start;

            leftSum += arr[start];
        }


        return -1;

    }
}
