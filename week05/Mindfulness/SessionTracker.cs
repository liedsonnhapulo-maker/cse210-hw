using System;

public class SessionTracker
{
    public int BreathingCount { get; private set; }
    public int ReflectionCount { get; private set; }
    public int ListingCount { get; private set; }

    public void AddBreathing() => BreathingCount++;
    public void AddReflection() => ReflectionCount++;
    public void AddListing() => ListingCount++;

    public void ShowSummary()
    {
        Console.WriteLine("\n=== Session Summary ===");
        Console.WriteLine($"Breathing Activity: {BreathingCount}");
        Console.WriteLine($"Reflection Activity: {ReflectionCount}");
        Console.WriteLine($"Listing Activity: {ListingCount}");
        Console.WriteLine("======================\n");
    }
}