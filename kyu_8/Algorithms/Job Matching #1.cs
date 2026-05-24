using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Algorithms;

public class Candidate(double MinSalary)
{
    public double MinSalary { get; set; } = MinSalary;
}

public class Job(double MaxSalary)
{
    public double MaxSalary { get; set; } = MaxSalary;
}
internal class Job_Matching__1
{
    public static bool Match(Candidate c, Job j)
    {
        //if (c.MinSalary is null || j.MaxSalary is null)
        //    throw new Exception();

        return c.MinSalary * 0.9 <= j.MaxSalary;
    }
}
