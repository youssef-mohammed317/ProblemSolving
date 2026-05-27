using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_7.Arrays;

public class Person
{
    public string Name { get; set; }
    public bool WasNice { get; set; }
}
internal class Naughty_or_Nice
{
    public static IEnumerable<string> GetNiceNames(IEnumerable<Person> people)
    {
        return people.Where(p => p.WasNice).Select(p => p.Name);
    }

    public static IEnumerable<string> GetNaughtyNames(IEnumerable<Person> people)
    {
        return people.Where(p => !p.WasNice).Select(p => p.Name);
    }
}
