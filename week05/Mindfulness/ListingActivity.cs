using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "List people you appreciate.",
        "List your personal strengths.",
        "List people you helped recently.",
        "List your heroes.",
        "List moments you felt happy this month."
    };

    public ListingActivity(SessionTracker tracker)
        : base(
            "Listing Activity",
            "This activity helps you list positive things in your life.",
            tracker)
    { }

    public override void Run()
    {
        _tracker.AddListing();

        Start();

        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine("\n" + prompt);
        Console.WriteLine("Get ready...");
        ShowCountdown(5);

        int duration = GetDuration();
        int endTime = Environment.TickCount + duration * 1000;

        int count = 0;

        Console.WriteLine("\nStart listing:");

        while (Environment.TickCount < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            count++;
        }

        Console.WriteLine($"\nYou listed {count} items!");

        End();
    }
}