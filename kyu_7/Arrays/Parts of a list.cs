using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Parts_of_a_list
{
    public static string[][] Partlist(string[] arr)
    {
        string[][] res = new string[arr.Length - 1][];
        for (int i = 1; i < arr.Length; i++)
        {
            res[i - 1] = [string.Join(" ", arr.Take(i)), string.Join(" ", arr.Skip(i))];
        }
        return res;
    }
}
