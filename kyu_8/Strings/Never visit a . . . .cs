using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.Strings;

internal class Never_visit_a
{
    static string[] fruits = new string[]
    {
        "kiwi", "pear", "kiwi", "banana", "melon", "banana", "melon", "pineapple", "apple", "pineapple",
        "cucumber", "pineapple", "cucumber", "orange", "grape", "orange", "grape", "apple", "grape", "cherry",
        "pear", "cherry", "pear", "kiwi", "banana", "kiwi", "apple", "melon", "banana", "melon",
        "pineapple", "melon", "pineapple", "cucumber", "orange", "apple", "orange", "grape", "orange", "grape",
        "cherry", "pear", "cherry", "pear", "apple", "pear", "kiwi", "banana", "kiwi", "banana",
        "melon", "pineapple", "melon", "apple", "cucumber", "pineapple", "cucumber", "orange", "cucumber", "orange",
        "grape", "cherry", "apple", "cherry", "pear", "cherry", "pear", "kiwi", "pear", "kiwi",
        "banana", "apple", "banana", "melon", "pineapple", "melon", "pineapple", "cucumber", "pineapple", "cucumber",
        "apple", "grape", "orange", "grape", "cherry", "grape", "cherry", "pear", "cherry", "apple",
        "kiwi", "banana", "kiwi", "banana", "melon", "banana", "melon", "pineapple", "apple", "pineapple"
    };
    public static string SubtractSum(int number)
    {
        int sum = 0,n = number;
        while(n > 0)
        {
            sum += n % 10;
            n /= 10;
        }

        number -= sum;
        
        if(number >= 1 && number <= 100)
        {
            return fruits[number - 1];
        }    
        return SubtractSum(number);
    }
}
