// See https://aka.ms/new-console-template for more information
using nunitExample;

Console.WriteLine("Hello, World!");

Person _person = new ()
{
    Fname = "Richard",
    Mname = "W.",
    Lname = "Scott"
};

//Act
string fullName = _person.GetFullName();
Console.WriteLine(fullName);
