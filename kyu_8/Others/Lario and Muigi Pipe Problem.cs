using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Others;

internal class Lario_and_Muigi_Pipe_Problem
{
    public static List<int> PipeFix(List<int> numbers)
    {
        return Enumerable.Range(numbers.Min(), numbers.Max() - numbers.Min() + 1).ToList();
    }
}
