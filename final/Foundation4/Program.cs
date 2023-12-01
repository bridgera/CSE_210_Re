using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        List<Activity> activityList = new List<Activity>();

        Running running = new Running("11/30/2023", 16, 2.3);
        activityList.Add(running);

        Cycling cycling = new Cycling("9/01/2022", 20, 8.6);
        activityList.Add(cycling);

        Swimming swimming = new Swimming("12/23/2021", 3, 5);
        activityList.Add(swimming);
        

        foreach (Activity activity in activityList)
        {
            activity.GetSummary();
            Console.WriteLine("");
        }

        
    }
}