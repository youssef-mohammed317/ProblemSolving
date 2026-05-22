using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class I_love_you_a_little__a_lot_passionately_not_at_all
{
    public static string HowMuchILoveYou(int nb_petals)
    {
        var arr = new string[]{
            "I love you",
            "a little",
            "a lot",
            "passionately",
            "madly",
            "not at all"
            };
        var i = nb_petals % 6;
        return arr[i == 0 ? 5 : i - 1];
    }
}
