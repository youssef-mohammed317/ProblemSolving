using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kyu_8.OOP;

internal class Fun_with_ES6_Classes_1___People_people_people
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }
    public Fun_with_ES6_Classes_1___People_people_people(string firstName = "John", string lastName = "Doe", int age = 0, string gender = "Male")
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
        this.Gender = gender;
    }
    public string SayFullName()
    {
        return string.Join(" ", FirstName, LastName);
    }
    public static string GreetExtraTerrestrials(string raceName)
    {
        return $"Welcome to Planet Earth {raceName}";
    }
}