using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Mathematics;

internal class Wilson_primes
{
    static BigInteger Fact(int n)
    {
        var fact = BigInteger.One;
        while (n > 1)
        {
            fact = fact * n;
            n--;
        }
        return fact;
    }
    public static bool AmIWilson(int p)
    {
        //var numerator = Enumerable.Range(1, p - 1).Aggregate(1, (fact, x) => fact * x) + 1;
        var numerator = Fact(p - 1) + 1;
        var denominator = p * p;
        return numerator % denominator == 0;
        //return p == 5 || p == 13 || p == 563;
    }
}
