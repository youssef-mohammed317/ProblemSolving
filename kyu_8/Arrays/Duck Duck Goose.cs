using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Arrays;

internal class Duck_Duck_Goose
{
    public static string DuckDuckGoose(Player[] players, int goose)
    {
        int index = (goose % players.Length);
        if (index == 0) index = players.Length;
        return players[index - 1].Name;
    }
}
public class Player
{
    public string Name { get; set; }

    public Player(string name)
    {
        this.Name = name;
    }
}