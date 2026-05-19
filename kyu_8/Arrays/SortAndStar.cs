using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CodeWars;

public class StrComparer : IComparer<string>
{
    public int Compare(string? x, string? y)
    {
        if (x == null && y == null) return 0;
        if (x == null && y != null) return -1;
        if (y == null && x != null) return 1;

        int i = 0, j = 0;

        while (i < x.Length && j < y.Length)
        {
            if (x[i] > y[j]) return 1;
            if (x[i] < y[j]) return -1;
            i++; j++;
        }

        if (i < x.Length) return -1;
        if (j < x.Length) return 1;

        return 0;
    }
}
public class Kata
{
    public static string TwoSort(string[] s)
    {
        //Array.Sort(s, new StrComparer());
        Array.Sort(s, StringComparer.Ordinal);
        return string.Join("***", s[0].Select(c => c).ToArray());
    }
}