using System;

namespace Develop02
{
    public class Entry
    {
        public string Prompt;
        public string Response;
        public string Date; 
        
        public void SetPrompt(string prompt)
        {
            Prompt = prompt;
        }
        public void SetResponse(string response)
        {
            Response = response;
        }
        public void SetDate(string date = null)
        {
            if (date == null)
            {
                Date = DateTime.Now.ToString("MM/dd/yyyy");
            }
            else
            {
                Date = date;
            }
        }

        public void DisplayEntry()
        {
            Console.WriteLine($"Date: {Date} - Prompt: {Prompt}");
            Console.WriteLine(Response);
            Console.WriteLine("-----------------------------");
        }
    }
}
