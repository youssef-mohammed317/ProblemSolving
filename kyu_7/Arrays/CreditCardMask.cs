using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

internal class CreditCardMask
{
    public static string Maskify(string cc)
    {
        if (cc.Length <= 4) return cc;
        //return string.Concat(string.Join("", cc.Substring(0, cc.Length - 4).Select(c => "#")), (cc.Substring(cc.Length - 4)));
        return cc.Substring(cc.Length - 4).PadLeft(cc.Length, '#');
    }
}
