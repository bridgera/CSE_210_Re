using System;
using System.Collections.Generic;

namespace Develop02
{
    public class PromptGenerator
    {
        private List<string> prompts;
        private Random random;

        public PromptGenerator()
        {
            prompts = new List<string>
            {
                "What was the best part of your day?",
                "Describe the dream you had last night.",
                "What's a goal you want to achieve this year?",
                "Write about a memory.",
                "How do you feel?",
            };

            random = new Random();
        }

        public string GetRandomPrompt()
        {
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }
}
