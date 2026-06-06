using System;

class Program
{
    static void Main(string[] args)
    {
        SessionTracker tracker = new SessionTracker();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. View Session Summary");
            Console.WriteLine("5. Exit");

            Console.Write("\nSelect option: ");
            string choice = Console.ReadLine();

            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity(tracker);
                    break;

                case "2":
                    activity = new ReflectionActivity(tracker);
                    break;

                case "3":
                    activity = new ListingActivity(tracker);
                    break;

                case "4":
                    tracker.ShowSummary();
                    Console.WriteLine("Press Enter...");
                    Console.ReadLine();
                    continue;

                case "5":
                    tracker.ShowSummary();
                    return;
            }

            activity?.Run();
        }
    }
}