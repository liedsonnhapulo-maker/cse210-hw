using System;

// Exceeded Requirements:
// - Added current time to journal entries
// - Added total journal entry counter

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        bool running = true;

        while (running)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            Console.Write("Select a choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();

                Console.WriteLine();
                Console.WriteLine(prompt);
                Console.Write("> ");

                string response = Console.ReadLine();

                Entry newEntry = new Entry();

                newEntry._date = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                newEntry._promptText = prompt;
                newEntry._entryText = response;

                journal.AddEntry(newEntry);

                Console.WriteLine("Entry added.");
                Console.WriteLine();
            }
            else if (choice == "2")
            {
                Console.WriteLine();
                journal.Display();
            }
            else if (choice == "3")
            {
                Console.Write("Enter filename: ");
                string file = Console.ReadLine();

                journal.SaveFile(file);

                Console.WriteLine("Journal saved.");
                Console.WriteLine();
            }
            else if (choice == "4")
            {
                Console.Write("Enter filename: ");
                string file = Console.ReadLine();

                journal.LoadFile(file);

                Console.WriteLine("Journal loaded.");
                Console.WriteLine();
            }
            else if (choice == "5")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid option.");
                Console.WriteLine();
            }
        }
    }
}