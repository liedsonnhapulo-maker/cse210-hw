using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "How are you feeling today?",
        "Are you doing okay today?",
        "What was the best part of your day?",
        "What made you smile today?",
        "What was the hardest thing today?",
        "Did you help someone today?",
        "What are you grateful for today?",
        "What did you learn today?",
        "What made you feel proud today?",
        "Who was the most interesting person you talked to today?",
        "What was your strongest emotion today?",
        "If you could repeat one moment today, what would it be?",
        "Did anything surprise you today?",
        "What goal do you want to achieve tomorrow?",
        "What is something you want to improve in yourself?",
        "Did you feel stressed today? Why?",
        "What is one thing that gave you peace today?",
        "How did you see the hand of the Lord in your life today?",
        "What was your favorite moment today?",
        "What would make tomorrow better?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();

        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}