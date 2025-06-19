using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
            manager.LoadGoals();

            while (true)
            {
                Console.WriteLine($"\nEternal Quest - Total Points: {manager.TotalScore}");
                Console.WriteLine("1. List Goals");
                Console.WriteLine("2. Add Goal");
                Console.WriteLine("3. Record Event");
                Console.WriteLine("4. Save and Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        manager.ListGoals();
                        break;
                    case "2":
                        manager.AddGoal();
                        break;
                    case "3":
                        manager.RecordEvent();
                        break;
                    case "4":
                        manager.SaveGoals();
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
    }
}