using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.OOP;

internal class Classy_Classes
{
    public int Age { get; set; }
    public string Name { get; set; }
    public Classy_Classes(string name, int age)
    {
        Age = age;
        Name = name;
    }
    public string Info { get { return $"{Name}s age is {Age}"; } }
}