using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction one = new Fraction();
        Fraction overOne = new Fraction(5);
        Fraction topAndBottom = new Fraction(3, 4);
        Fraction topAndBottomAgain = new Fraction(1, 3);
        
        // one.GetTop();
        // one.GetBottom();
        // overOne.GetTop();
        // overOne.GetBottom();
        // topAndBottom.GetTop();
        // topAndBottom.GetBottom();

        Console.WriteLine(one.GetFractionString());
        Console.WriteLine(one.GetDecimalValue());
        Console.WriteLine(overOne.GetFractionString());
        Console.WriteLine(overOne.GetDecimalValue());
        Console.WriteLine(topAndBottom.GetFractionString());
        Console.WriteLine(topAndBottom.GetDecimalValue());
        Console.WriteLine(topAndBottomAgain.GetFractionString());
        Console.WriteLine(topAndBottomAgain.GetDecimalValue());

    }
}