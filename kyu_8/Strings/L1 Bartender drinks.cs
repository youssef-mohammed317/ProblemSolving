using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Strings;

internal class L1_Bartender_drinks
{
    public static string GetDrinkByProfession(string p)
    {
        return p.ToLower() switch
        {
            "jabroni" => "Patron Tequila",
            "school counselor" => "Anything with Alcohol",
            "programmer" => "Hipster Craft Beer",
            "bike gang member" => "Moonshine",
            "politician" => "Your tax dollars",
            "rapper" => "Cristal",
            _ => "Beer"
        };
    }
}
