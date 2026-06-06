using System;

public class BreathingActivity : Activity
{
    public BreathingActivity(SessionTracker tracker)
        : base(
            "Breathing Activity",
            "This activity helps you relax by guiding slow breathing.",
            tracker)
    { }

    public override void Run()
    {
        _tracker.AddBreathing();

        Start();

        int duration = GetDuration();
        int elapsed = 0;

        while (elapsed < duration)
        {
            Console.Write("\nBreathe in...");
            ShowCountdown(4);
            elapsed += 4;

            Console.Write("\nBreathe out...");
            ShowCountdown(4);
            elapsed += 4;
        }

        End();
    }
}