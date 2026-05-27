using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Genetic_Algorithm_Series_1_Generate
{
    public string Generate(int length)
    {
        return string.Concat(Enumerable.Range(1, length).Select(x => Random.Shared.Next(0, 2)));
    }
}
