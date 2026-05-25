using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Others;

internal class Are_they_opposite
{
    public static bool IsOpposite(string s1, string s2)
    {
        if (s1.Length != s2.Length || s1 == "" || s2 == "" || s1.ToUpper() != s2.ToUpper())
            return false;

        int i = 0;

        while (i < s1.Length)
        {
            if ((char.IsUpper(s1[i]) && char.IsUpper(s2[i])) || (char.IsLower(s1[i]) && char.IsLower(s2[i])))
            {
                return false;
            }
            i++;
        }
        if (i == s1.Length)
            return true;

        return false;
        // string.IsNullOrEmpty(s1) ? false :
        // s1.SequenceEqual(s2.Select(e => Char.IsLower(e) ? Char.ToUpper(e) : Char.ToLower(e)));
    }
}
