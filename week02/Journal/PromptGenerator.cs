using System;

public class PromptGenerator
{
    string[] prompts = [
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "what are my major lessons from today?",
        "What did I do today that align with my goals and values?",
        "What inspired or motivated me today, and how can I carry that forward?",
        "What moment today made me feel most grateful and why?"
    ];

    public string GetRandomPrompt()
    {
        Random random = new Random();

        int randomIndex = random.Next(0, prompts.Count());

        return prompts[randomIndex];
    }
}