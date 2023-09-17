using System;

class Program
{
    static void Main(string[] args)
    {
        string letterGrade = "";

        Console.Write("What is your grade percentage? ");
        string strPercent = Console.ReadLine();
        float percent = int.Parse(strPercent);
        float lastDigit = percent % 10;
        string plusMinus = "";

        // determine plusMinus
        if (lastDigit >= 7)
        {
            plusMinus = "+";
        }

        else if (lastDigit < 3)
        {
            plusMinus = "-";
        }

        // determine letter grade
        if (percent >= 97)
        {
            letterGrade = "A";
            plusMinus = "";
        }

        else if (percent >= 90)
        {
            letterGrade = "A";
        }

        else if (percent >= 80)
        {
            letterGrade = "B";
        }

        else if (percent >= 70)
        {
            letterGrade = "C";
        }

        else if (percent >= 60)
        {
            letterGrade = "D";
        }

        else if (percent < 60)
        {
            letterGrade = "F";
            plusMinus = "";
        }

        Console.WriteLine($"You recieved a(n) {letterGrade}{plusMinus}");

        if (percent < 70)
        {
            Console.WriteLine("You didn't pass! Better luck next semester ;)");
        }

        else
        {
            Console.WriteLine("Congrats you passed!");
        }
    }
}