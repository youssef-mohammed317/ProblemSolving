using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Debugging;

internal class Filtering_even_numbers_Bug_Fixes
{
    public static List<int> FilterOddNumber(List<int> listOfNumbers)
    {
        for (int i = 0; i < listOfNumbers.Count; i++)
        {
            if (listOfNumbers[i] % 2 == 0)
            {
                listOfNumbers.RemoveAt(i);
                i--;
            }
        }
        return listOfNumbers;
    }
}
