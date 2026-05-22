using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class Find_the_Difference_in_Age_between_Oldest_and_Youngest_Family_Members
{
    public static int[] DifferenceInAges(int[] ages)
    {
        return [ages.Min(), ages.Max(), ages.Max() - ages.Min()];
    }
}
