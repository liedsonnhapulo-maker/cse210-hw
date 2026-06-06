using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time you stood up for someone.",
        "Think of a time you overcame a challenge.",
        "Think of a time you helped someone in need.",
        "Think of a time you did something selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this meaningful?",
        "How did you feel?",
        "What did you learn about yourself?",
        "What made this experience special?",
        "How can you use this in the future?",
        "What was the hardest part?"
    };

    private Random _random = new Random();

    public ReflectionActivity(SessionTracker tracker)
        : base(
            "Reflection Activity",
            "This activity helps you reflect on moments of strength.",
            tracker)
    { }

    public override void Run()
    {
        _tracker.AddReflection();

        Start();

        Console.WriteLine("\nPrompt:");
        Console.WriteLine(_prompts[_random.Next(_prompts.Count)]);

        Console.WriteLine("\nGet ready...");
        ShowSpinner(3);

        int duration = GetDuration();
        int elapsed = 0;

        while (elapsed < duration)
        {
            string question = _questions[_random.Next(_questions.Count)];
            Console.WriteLine("\n" + question);
            ShowSpinner(3);
            elapsed += 3;
        }

        End();
    }
}