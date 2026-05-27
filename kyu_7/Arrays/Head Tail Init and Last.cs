using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Head_Tail_Init_and_Last
{
    public static TSource Head<TSource>(List<TSource> list)
    {
        return list.FirstOrDefault();
    }

    public static List<TSource> Tail<TSource>(List<TSource> list)
    {
        return list.Skip(1).ToList();
    }

    public static List<TSource> Init<TSource>(List<TSource> list)
    {
        return list.SkipLast(1).ToList();
    }

    public static TSource Last_<TSource>(List<TSource> list)
    {
        return list.LastOrDefault();
    }
}
