using System;

namespace Develop02
{
    public class Entry
    {
        public string Prompt { get; set; }
        public string Response { get; set; }
        public string Date { get; set; } = DateTime.Now.ToString("MM/dd/yyyy"); 
        
        public string DisplayEntry()
        {
            return $"Date: {Date} - Prompt: {Prompt}\n{Response}";
        }

        public void UpdateToCurrentDate()
        {
            Date = DateTime.Now.ToString("MM/dd/yyyy");
        }
    }
}
