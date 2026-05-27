using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Genetic_Algorithm_Series_3_Crossover
{
    public IEnumerable<string> Crossover(string chromosome1, string chromosome2, int cut)
    {
        //return new[] { chromosome1[..cut] + chromosome2[cut..], chromosome2[..cut] + chromosome1[cut..] };

        return [string.Concat(chromosome1.Substring(0, cut), chromosome2.Substring(cut)), string.Concat(chromosome2.Substring(0, cut), chromosome1.Substring(cut))];
    }
}
