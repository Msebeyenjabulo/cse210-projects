using System;
using System.Collections.Generic;
using System.Linq;

public class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int score = 0;

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("Eternal Quest Program");
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Display Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddGoal();
                    break;
                case "2":
                    RecordEvent();
                    break;
                case "3":
                    DisplayGoals();
                    break;
                case "4":
                    DisplayScore();
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private void AddGoal()
    {
        Console.WriteLine("Enter goal type (1. Simple, 2. Eternal, 3. Checklist): ");
        string type = Console.ReadLine();

        Console.WriteLine("Enter goal name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Enter goal description: ");
        string description = Console.ReadLine();

        Console.WriteLine("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        Goal goal;
        switch (type)
        {
            case "1":
                goal = new SimpleGoal(name, description, points);
                break;
            case "2":
                goal = new EternalGoal(name, description, points);
                break;
            case "3":
                Console.WriteLine("Enter required completions: ");
                int requiredCompletions = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());

                goal = new ChecklistGoal(name, description, points, requiredCompletions, bonusPoints);
                break;
            default:
                Console.WriteLine("Invalid goal type. Goal not added.");
                return;
        }

        goals.Add(goal);
        Console.WriteLine("Goal added successfully.");
    }

    private void RecordEvent()
    {
        Console.WriteLine("Enter goal name to record event: ");
        string name = Console.ReadLine();

        var goal = goals.FirstOrDefault(g => g.Name == name);
        if (goal != null)
        {
            goal.RecordEvent();
            score += goal.Points;
            Console.WriteLine("Event recorded.");
        }
        else
        {
            Console.WriteLine("Goal not found.");
        }
    }

    private void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.GetStatus());
        }
    }

    private void DisplayScore()
    {
        Console.WriteLine("Current Score: " + score);
    }

    private void SaveGoals()
    {
        // save goals and score to a file
    }

    private void LoadGoals()
    {
        // Code to load goals and score from a file
    }
}
