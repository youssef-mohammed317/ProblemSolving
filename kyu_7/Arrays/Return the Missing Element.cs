using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class Return_the_Missing_Element
{
    public static int GetMissingElement(int[] superImportantArray)
    {
        //return Enumerable.Range(superImportantArray.Min(), superImportantArray.Max() - superImportantArray.Min() + 1).Except(superImportantArray).FirstOrDefault();

        Array.Sort(superImportantArray);
        for (int i = 0; i < superImportantArray.Length; i++)
        {
            if (superImportantArray[i] != i)
                return i;
        }
        return superImportantArray.Length + 1;

    }
}
