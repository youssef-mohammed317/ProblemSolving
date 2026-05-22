using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class CSV_RepresentationOfArray
{
    public static string ToCsvText(int[][] array)
    {
        StringBuilder stringBuilder = new StringBuilder();

        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                if (j != 0)
                    stringBuilder.Append(",");
                stringBuilder.Append(array[i][j]);
            }
            if (i < array.Length - 1)
                stringBuilder.Append('\n');
        }

        return stringBuilder.ToString();

        //return string.Join("\n", array.Select(x => string.Join(",", x)));

    }
}
