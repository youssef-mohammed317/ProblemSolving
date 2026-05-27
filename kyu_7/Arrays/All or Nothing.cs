using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class All_or_Nothing
{
    public static bool PossiblyPerfect(string[] key, string[] ans)
    {
        bool prevCorrect = false, prevInCorrect = false;
        for (int i = 0; i < key.Length; i++)
        {
            if (key[i] == "_")
                continue;

            if (ans[i] == key[i])
            {
                prevCorrect = true;
            }
            else
            {
                prevInCorrect = true;
            }
        }

        return !(prevInCorrect & prevCorrect);
    }
}
