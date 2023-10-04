using System;

namespace Learning02
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create Job 1 Instance //
            Job job1 = new Job();
            job1._company = "Microsoft";
            job1._endYear = 2008;
            job1._jobTitle = "Software Engineer";
            job1._startYear = 2001;


            // Creat Job2 Instance //
            Job job2 = new Job();
            job2._company = "Apple";
            job2._endYear = 2023;
            job2._jobTitle = "CEO";
            job2._startYear = 2017;

            // Create Job3 Instance //
            Job job3 = new Job();
            job3._company = "Meta";
            job3._endYear = 2024;
            job3._jobTitle = "AI brain doner";
            job3._startYear = 2099;

            // Create bridgerResume Instance //
            Resume bridgerResume = new Resume();
            bridgerResume._userName = "Bridger Allen";
            bridgerResume._jobList.Add(job1);
            bridgerResume._jobList.Add(job2);   
            bridgerResume._jobList.Add(job3);

            // Display Resume//
            bridgerResume.Display();
            
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            System.Environment.Exit(1);


        }
    }
}

