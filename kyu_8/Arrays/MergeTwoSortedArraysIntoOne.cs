using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class MergeTwoSortedArraysIntoOne
{
    public static int[] MergeArrays(int[] arr1, int[] arr2)
    {
        Array.Sort(arr1);
        Array.Sort(arr2);

        int[] res = new int[arr1.Length + arr2.Length];
        int i = 0, j = 0, k = 0;
        while (i < arr1.Length && j < arr2.Length)
        {
            if (arr1[i] < arr2[j])
            {
                res[k++] = arr1[i++];
            }
            else if (arr1[i] > arr2[j])
            {
                res[k++] = arr2[j++];
            }
            else
            {
                res[k++] = arr1[i++]; j++;
            }
        }
        while (i < arr1.Length)
        {
            res[k++] = arr1[i++];
        }
        while (j < arr2.Length)
        {
            res[k++] = arr2[j++];
        }
        Array.Resize(ref res, k);
        return res;
        //arr1.Union(arr2).OrderBy(i => i).ToArray();
    }
}
