using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Debugging;

internal class Broken_Counter
{
    private int value;

    public int Value { get { return value; } set { this.value = value; } }
    public Broken_Counter()
    {
        Value = 0;
    }

    public void Increase()
    {
        ++Value;
    }

    public void Reset()
    {
        Value = 0;
    }
}
