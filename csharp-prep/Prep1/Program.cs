using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("What is your First Name?");
        string firstName = Console.ReadLine();
        Console.WriteLine("What is your Last Name?");
        string lastName = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}");
    }

}