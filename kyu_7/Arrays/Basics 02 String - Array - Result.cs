using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Basics_02_String___Array___Result
{
    public string calculateArray(string stringArray)
    {
        var ints = stringArray.Split(";").Where(x => int.TryParse(x, out var val)).Select(x => int.Parse(x));
        var sum = ints.Sum();
        var avg = (int)Math.Round(ints.Average());
        int digitsSum = 0;
        int num = avg;
        while (num > 0)
        {
            digitsSum += num % 10;
            num /= 10;
        }
        var div = digitsSum % 5 == 0 ? "TRUE" : "FALSE";
        return $"{avg},{digitsSum},{div}";
    }
}
