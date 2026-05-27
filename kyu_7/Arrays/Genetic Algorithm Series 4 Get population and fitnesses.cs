using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

public class ChromosomeWrap
{
    public string Chromosome { get; set; }
    public double Fitness { get; set; }
}
internal class Genetic_Algorithm_Series_4_Get_population_and_fitnesses
{
    public IEnumerable<ChromosomeWrap> MapPopulationFit(IEnumerable<string> population, Func<string, double> fitness)
    {
        return population.Select(pop => new ChromosomeWrap
        {
            Chromosome = pop,
            Fitness = fitness(pop)
        });
    }
}
