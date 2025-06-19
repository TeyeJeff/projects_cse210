using System;


public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public int TotalScore => _score; 


    public void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals yet!");
            return;
        }
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()} {(_goals[i].IsComplete() ? "(Completed)" : "")}");
        }
    }

    public void AddGoal()
    {
        Console.WriteLine("Goal Types: 1. Simple 2. Eternal 3. Checklist");
        Console.Write("Select a goal type: ");
        string type = Console.ReadLine();
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string description = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (type)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Bonus points: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                _goals.Add(new CheckListGoal(name, description, points, targetCount, bonusPoints));
                break;
            default:
                Console.WriteLine("Invalid goal selection.");
                break;
            }
        }

    public void RecordEvent()
    {
        ListGoals();
        Console.Write("Enter goal number to record: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= _goals.Count)
        {
            int pointsEarned = _goals[index - 1].RecordEvent();
            _score += pointsEarned;
            Console.WriteLine($"Recorded! Points Earned {pointsEarned} points.");
        }
        else
        {
            Console.WriteLine("Invalid Selection!!");
        }
    }

    public void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Saved Succesfully!");
    }

    public void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            using (StreamReader reader = new StreamReader("goals.txt"))

            {
                _score = int.Parse(reader.ReadLine());
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    switch (parts[0])
                    {
                        case "SimpleGoal":
                            SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                            _goals.Add(simpleGoal);
                            break;
                        case "EternalGoal":
                            _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                            break;
                        case "ChecklistGoal":
                            CheckListGoal checkListGoal = new CheckListGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[6]), int.Parse(parts[5]));
                            _goals.Add(checkListGoal);
                            break;
                    }
                }
                Console.WriteLine("Goals loaded!");
            }   
                
        }
    }


}