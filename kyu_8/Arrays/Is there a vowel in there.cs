using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class Is_there_a_vowel_in_there
{
    public static object[] IsVow(int[] a)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

        return a.Select(x => vowels.Contains((char)x) ? (object)((char)x).ToString() : (object)x)
          .ToArray();
    }
}
