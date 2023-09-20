using System;

class Program
{
    static void Main(string[] args)
    {
        Random rand = new Random();
        int number = rand.Next(1,100);

        int guessedNumber = 0;

        int hintCounter = 0;

        Console.WriteLine("I'm thinking of a magic number between 1 and 100");

        
        while (guessedNumber != number && hintCounter < 8)

        {
            Console.Write("What is your guess?: ");
            string guessedNumberStr = Console.ReadLine();

            guessedNumber = int.Parse(guessedNumberStr);

            //HIgher or lowers
            if (number > guessedNumber)
            {
                Console.WriteLine("Higher!");
            }

            else if (number < guessedNumber)
            {
                Console.WriteLine("Lower!");
            }

            //Hints display
            if (hintCounter == 5 && guessedNumber != number)
            {
                Console.WriteLine($"The magic number is {number*2} divided by 2");
            }
            hintCounter += 1;
        }


        //Congrats
        if (guessedNumber == number && hintCounter != 8)
        {
            Console.WriteLine("Congrats you Won!!");
        }
        //Failed
        if (hintCounter == 8)
        {
            Console.WriteLine("You failed.");
        }
    }
}