using System;
using System.Collections.Generic;

namespace Develop02
{
    public class PromptGenerator
    {
        private List<string> _prompts;
        private Random _random;

        public PromptGenerator()
        {
            _prompts = new List<string>
            {
                "What was the best part of your day?",
                "Describe the dream you had last night.",
                "What's a goal you want to achieve this year?",
                "Write about a memory.",
                "How do you feel?",
            };

            _random = new Random();
        }

        public string GetRandomPrompt()
        {
            int index = _random.Next(_prompts.Count);
            return _prompts[index];
        }
    }
}
