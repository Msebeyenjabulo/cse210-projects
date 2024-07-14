using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public class GoalManager
    {
        private List<Goal> _goals = new List<Goal>();
        private int _score;

        public void Start()
        {
            // Load goals
            LoadGoals();
            
            // Main menu loop
            while (true)
            {
                DisplayPlayerInfo();
                Console.WriteLine("1. List Goals");
                Console.WriteLine("2. Create Goal");
                Console.WriteLine("3. Record Event");
                Console.WriteLine("4. Save Goals");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ListGoalDetails();
                        break;
                    case "2":
                        CreateGoal();
                        break;
                    case "3":
                        RecordEvent();
                        break;
                    case "4":
                        SaveGoals();
                        break;
                    case "5":
                        return;
                }
            }
        }

        public void DisplayPlayerInfo()
        {
            Console.Clear();
            Console.WriteLine($"Score: {_score}");
        }

        public void ListGoalDetails()
        {
            Console.WriteLine("Goals:");
            foreach (var goal in _goals)
            {
                Console.WriteLine(goal.GetDetailsString());
            }
        }

        public void CreateGoal()
        {
            Console.WriteLine("Select goal type:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            Goal goal = GoalFactory.CreateGoal(choice);
            if (goal != null)
            {
                _goals.Add(goal);
            }
        }

        public void RecordEvent()
        {
            Console.WriteLine("Enter goal name to record event:");
            string name = Console.ReadLine();

            foreach (var goal in _goals)
            {
                if (goal.Name == name)
                {
                    goal.RecordEvent();
                    _score += goal.Points;
                    if (goal.IsComplete())
                    {
                        Console.WriteLine("Goal completed!");
                    }
                    return;
                }
            }

            Console.WriteLine("Goal not found.");
        }

        public void SaveGoals()
        {
            using (StreamWriter outputFile = new StreamWriter("goals.txt"))
            {
                outputFile.WriteLine(_score);
                foreach (var goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }
        }

        public void LoadGoals()
        {
            if (File.Exists("goals.txt"))
            {
                string[] lines = File.ReadAllLines("goals.txt");
                _score = int.Parse(lines[0]);

                for (int i = 1; i < lines.Length; i++)
                {
                    Goal goal = GoalFactory.CreateGoalFromString(lines[i]);
                    if (goal != null)
                    {
                        _goals.Add(goal);
                    }
                }
            }
        }
    }
}
