namespace EternalQuest
{
    public static class GoalFactory
    {
        public static Goal CreateGoal(string choice)
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter description: ");
            string description = Console.ReadLine();
            Console.Write("Enter points: ");
            int points = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case "1":
                    return new SimpleGoal(name, description, points);
                case "2":
                    return new EternalGoal(name, description, points);
                case "3":
                    Console.Write("Enter target: ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("Enter bonus: ");
                    int bonus = int.Parse(Console.ReadLine());
                    return new ChecklistGoal(name, description, points, target, bonus);
                default:
                    return null;
            }
        }

        public static Goal CreateGoalFromString(string goalString)
        {
            string[] parts = goalString.Split(':');
            string type = parts[0];
            string[] details = parts[1].Split(',');

            string name = details[0];
            string description = details[1];
            int points = int.Parse(details[2]);

            switch (type)
            {
                case "SimpleGoal":
                    bool isComplete = bool.Parse(details[3]);
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points)
                    {
                        IsComplete = isComplete
                    };
                    return simpleGoal;
                case "EternalGoal":
                    return new EternalGoal(name, description, points);
                case "ChecklistGoal":
                    int amountCompleted = int.Parse(details[3]);
                    int target = int.Parse(details[4]);
                    int bonus = int.Parse(details[5]);
                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus)
                    {
                        AmountCompleted = amountCompleted
                    };
                    return checklistGoal;
                default:
                    return null;
            }
        }
    }
}
