using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Strings;

internal class DNA_to_RNA_Conversion
{
    public string dnaToRna(string dna)
    {
        return dna.Replace("T", "U");
    }
}
