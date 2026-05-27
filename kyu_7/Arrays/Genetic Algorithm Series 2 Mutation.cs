using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Genetic_Algorithm_Series_2_Mutation
{
    public string Mutate(string chromosome, double probability)
    {
        return string.Concat(chromosome.Select(c => (Random.Shared.Next(0, 101) < probability * 100 ? (c == '1' ? "0" : "1") : (c == '1' ? "1" : "0"))));
    }
}
