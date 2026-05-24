using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Debugging;

internal class else_syntax_debug
{
    private int health = 100;
    public int Health
    {
        get
        {
            return this.health;
        }
        set
        {
            health = value;
        }
    }

    public else_syntax_debug()
    {

    }

    //FIXME: This method won't compile for some reason! :(
    public bool CheckAlive()
    {
        return (this.Health > 0);

    }
}
