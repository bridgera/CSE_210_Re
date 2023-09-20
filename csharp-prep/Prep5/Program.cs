using System;

class Program
{
    static void DisplayWelcome(string displayMessage)
    {
        Console.WriteLine(displayMessage);
    }

    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static float PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        string favNumStr = Console.ReadLine();
        float favNum = float.Parse(favNumStr);
        return favNum;
    }

    static float SquareNumber(float userNumber)
    {
        float squaredNumber = userNumber * userNumber;
        return squaredNumber;
    }

    static void DisplayResult(float sqNum, string name)
    {
        Console.WriteLine($"{name}, the square of your number is {sqNum}");
    }

    static void Main(string[] args)
    {
        DisplayWelcome("Welcome to the program!");
        string userName = PromptUserName();
        float userNumber = PromptUserNumber();
        DisplayResult(SquareNumber(userNumber), userName);

    }
}