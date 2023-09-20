using System;
using System.Collections.Generic;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        List<float> numberList = new List<float>();
        float number = -1;
        float total = 0;
        float largestNum = 0;
        float smallestNum = 999999;
        Console.WriteLine("Enter a list of numbers, positive and negative, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter number: ");
            string numberStr = Console.ReadLine();
            number = float.Parse(numberStr);

            total += number;
            numberList.Add(number);

            if (number > largestNum)
            {
                largestNum = number;
            }

            if (number < smallestNum && number > 0)
            {
                smallestNum = number;
            }
        }

        numberList.Sort();

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {total / numberList.Count}");
        Console.WriteLine($"The largest number is {largestNum}");
        Console.WriteLine($"The smallest positive number is {smallestNum}");
        Console.WriteLine("Here is your list in order");

        foreach (float num in numberList)
        {
            Console.WriteLine(num);
        }



        
       

    }
}