using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What expenses do I think could've been avoided today?",
        "How did I see the hand of the Lord in my life today?",
        "One thing that I was proud of today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "Who was the most interesting person I interacted with today?",
        "What scripture inspired me today?",
        "What goal did I achieve today?",
        "Is there any advice or message I would like to share with tomorrow me?"

    };

    public PromptGenerator()
    {
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        return prompt;
    }
}