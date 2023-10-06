using System;

namespace Develop02
{
    public class Entry
    {
        public string _prompt;
        public string _response;
        public string _date; 
        
        public void SetPrompt(string prompt)
        {
            _prompt = prompt;
        }
        public void SetResponse(string response)
        {
            _response = response;
        }
        public void SetDate(string date = null)
        {
            if (_date == null)
            {
                _date = DateTime.Now.ToString("MM/dd/yyyy");
            }
            else
            {
                _date = date;
            }
        }

        public void DisplayEntry()
        {
            Console.WriteLine($"_date: {_date} - _prompt: {_prompt}");
            Console.WriteLine(_response);
            Console.WriteLine("-----------------------------");
        }
    }
}
