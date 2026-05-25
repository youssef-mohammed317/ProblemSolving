using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.OOP;

internal class OOP_Object_Oriented_Piracy
{
}
public class Ship
{
    public int Draft;
    public int Crew;

    public Ship(int draft, int crew)
    {
        Draft = draft;
        Crew = crew;
    }

    // YOUR CODE HERE...
    public bool IsWorthIt()
    {
        return Draft - Crew * 1.5 > 20;
    }
}