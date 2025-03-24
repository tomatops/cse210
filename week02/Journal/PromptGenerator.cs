using System;
using System.Collections.Generic;

// Supplies random prompts whenever needed.
public class PromptGenerator
{
    public List<string> _prompts;

    public string GetRandomPrompt()
    {
        Random i = new Random();
        
        List<string> _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        string prompt = _prompts[i.Next(_prompts.Count)];

        return prompt;
    }
}