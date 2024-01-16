using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // string concatenation
        // Console.WriteLine("Your name is " + lastName + ", " + firstName + " " + lastName); 

        // string formatting
        // Console.WriteLine("Your name is {0}, {1} {0}", lastName, firstName);
        
        // string interpolation
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");
    }
}
