//Added Negative Goal Class to exceed the requirements

class Program
{
    static void Main(string[] args)
    {
        Score score = new Score();
        string filePath = "goals.txt";

        while (true)
        {
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
                    AddGoal(score);
                    break;
                case "2":
                    RecordEvent(score);
                    break;
                case "3":
                    score.DisplayGoals();
                    break;
                case "4":
                    score.DisplayScore();
                    break;
                case "5":
                    score.Save(filePath);
                    break;
                case "6":
                    score.Load(filePath);
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    static void AddGoal(Score score)
    {
        Console.WriteLine("Select Goal Type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("4. Negative Goal");

        string goalType = Console.ReadLine();
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal score: ");
        int scoreValue = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "1":
                score.AddGoal(new SimpleGoal(name, scoreValue));
                break;
            case "2":
                score.AddGoal(new EternalGoal(name, scoreValue));
                break;
            case "3":
                Console.Write("Enter target count: ");
                int targetCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus score: ");
                int bonusScore = int.Parse(Console.ReadLine());
                score.AddGoal(new ChecklistGoal(name, scoreValue, targetCount, bonusScore));
                break;
            case "4":
                score.AddGoal(new NegativeGoal(name, scoreValue));
                break;
            default:
                Console.WriteLine("Invalid goal type. Try again.");
                break;
        }
    }

    static void RecordEvent(Score score)
    {
        Console.Write("Enter goal name to record: ");
        string name = Console.ReadLine();
        score.RecordGoal(name);
    }
}

