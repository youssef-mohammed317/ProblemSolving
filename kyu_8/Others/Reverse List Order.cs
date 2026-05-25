using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Others;

internal class Reverse_List_Order
{
    public static List<int> ReverseList(List<int> list)
    {
        // Return a new list with its elements in reverse order compared to the input list
        // Do not mutate the original list!

        return list.AsEnumerable().Reverse().ToList();
    }
}
