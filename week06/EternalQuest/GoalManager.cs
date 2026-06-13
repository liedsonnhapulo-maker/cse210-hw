using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    private int GetLevel()
    {
        if (_score >= 5000)
            return 4;

        if (_score >= 2500)
            return 3;

        if (_score >= 1000)
            return 2;

        return 1;
    }

    private string GetTitle()
    {
        if (_score >= 5000)
            return "Legend";

        if (_score >= 2500)
            return "Master";

        if (_score >= 1000)
            return "Disciple";

        return "Beginner";
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine("\n=======================");
        Console.WriteLine($"Score : {_score}");
        Console.WriteLine($"Level : {GetLevel()}");
        Console.WriteLine($"Title : {GetTitle()}");
        Console.WriteLine("=======================\n");
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("\nGoals:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("\nGoal Types:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Select: ");
        string choice = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(
                    new SimpleGoal(name, description, points));
                break;

            case "2":
                _goals.Add(
                    new EternalGoal(name, description, points));
                break;

            case "3":

                Console.Write("Target count: ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Bonus points: ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(
                    new ChecklistGoal(
                        name,
                        description,
                        points,
                        target,
                        bonus));

                break;
        }
    }

    public void RecordEvent()
    {
        ListGoalDetails();

        Console.Write("\nWhich goal did you complete? ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        int oldLevel = GetLevel();

        int pointsEarned =
            _goals[goalIndex].RecordEvent();

        _score += pointsEarned;

        Console.WriteLine(
            $"You earned {pointsEarned} points!");

        int newLevel = GetLevel();

        if (newLevel > oldLevel)
        {
            Console.WriteLine("\n************************");
            Console.WriteLine("LEVEL UP!");
            Console.WriteLine($"You are now Level {newLevel}");
            Console.WriteLine($"Title: {GetTitle()}");
            Console.WriteLine("************************");
        }
    }

    public void SaveGoals()
    {
        Console.Write("Filename: ");
        string file = Console.ReadLine();

        using (StreamWriter output =
               new StreamWriter(file))
        {
            output.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                output.WriteLine(
                    goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("Filename: ");
        string file = Console.ReadLine();

        string[] lines = File.ReadAllLines(file);

        _score = int.Parse(lines[0]);

        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');

            string type = parts[0];

            if (type == "SimpleGoal")
            {
                _goals.Add(
                    new SimpleGoal(
                        parts[1],
                        parts[2],
                        int.Parse(parts[3]),
                        bool.Parse(parts[4])));
            }

            else if (type == "EternalGoal")
            {
                _goals.Add(
                    new EternalGoal(
                        parts[1],
                        parts[2],
                        int.Parse(parts[3])));
            }

            else if (type == "ChecklistGoal")
            {
                _goals.Add(
                    new ChecklistGoal(
                        parts[1],
                        parts[2],
                        int.Parse(parts[3]),
                        int.Parse(parts[4]),
                        int.Parse(parts[5]),
                        int.Parse(parts[6])));
            }
        }
    }
}