using System.Diagnostics.Contracts;
using System.Drawing;

public class GoalManager
{
    private static List<Goal> _goals = new List<Goal>();

    private int _score = 0;

    public GoalManager()
    {

    }

    public void Start()
    {
        DisplayPlayerInfo();
    }

    private void DisplayPlayerInfo()
    {
        bool Quit = false;


        while (Quit != true)
        {
            Console.WriteLine($"\nYou have {_score} points");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Create New Goal");
            Console.WriteLine("   2. List Goals");
            Console.WriteLine("   3. Save Goals");
            Console.WriteLine("   4. Load Goals");
            Console.WriteLine("   5. Record Event");
            Console.WriteLine("   6. Quit ");
            Console.Write("Select a choice from the menu: ");
            string MenuOption = Console.ReadLine();

            if (MenuOption == "1")
            {
                CreateGoal();
            }
            else if (MenuOption == "2")
            {
                ListGoalDetails();
            }
            else if (MenuOption == "3")
            {
                SaveGoals();
            }
            else if (MenuOption == "4")
            {
                LoadGoals();
            }
            else if (MenuOption == "5")
            {
                RecordEvent();
            }
            else if (MenuOption == "6")
            {
                Quit = true;
            }
            else
            {
                Console.WriteLine("An error has occurred. Please try again.");
            }    
        }
    }

    private void ListGoalNames()
    {

    }

    private void ListGoalDetails()
    {
        int Number = 1;

        Console.WriteLine("The goals are:");
        
        foreach (Goal goal in _goals)
        {
            bool check = goal.IsComplete();
            string checkmark = "";

            if (check == false)
            {
                checkmark = "[ ]";
            }
            else if (check == true)
            {
                checkmark = "[X]";
            }
            
            Console.WriteLine($"\n{Number}. {checkmark} {goal.GetDetailsString()}");
            Number += 1;
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string GoalType = Console.ReadLine();
        
        Console.Write("What is the name of your goal? ");
        string GoalName = Console.ReadLine();
        
        Console.Write("What is a short description of it? ");
        string Description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        string PointAmount = Console.ReadLine();

        if (GoalType == "1")
        {
            SimpleGoal sg = new SimpleGoal(GoalName, Description, PointAmount);
            _goals.Add(sg);
        }
        else if (GoalType == "2")
        {
            EternalGoal eg = new EternalGoal(GoalName, Description, PointAmount);
            _goals.Add(eg);
        }
        else if (GoalType == "3")
        {
            Console.Write("How many time does this goal need to be accomplished for a bonus? ");
            string Target = Console.ReadLine();
            int TargetAmount = int.Parse(Target);

            Console.Write("What is the bonus for accomplishing it that many times? ");
            string Bonus = Console.ReadLine();
            int BonusReward = int.Parse(Bonus);

            ChecklistGoal cg = new ChecklistGoal(GoalName, Description, PointAmount, TargetAmount, BonusReward);
            _goals.Add(cg);
        }
    }

    private void RecordEvent()
    {
        int Number = 1;

        Console.WriteLine("The goals are:");

        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{Number}. {goal.GetDetailsString()}");
            Number += 1;
        }

        Console.Write("\n\nWhich goal did you accomplish? ");
        string Completed = Console.ReadLine();

        int CompletedGoal = int.Parse(Completed);
        CompletedGoal -= 1;
        int Reward = _goals[CompletedGoal].RecordEvent();
        _score += Reward;
        Console.WriteLine($"Congratulations! You have earned {Reward} points!");
        Console.WriteLine($"You now have {_score} points. (Press enter to continue)");
        Console.ReadLine();
    }

    private void SaveGoals()
    {
        string filename = "GoalProgress.txt";
        
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine($"{_score}");
            
            foreach (Goal goal in _goals)
            {
                writer.WriteLine($"{goal}|{goal.GetStringRepresentation()}");
            }
        }
    }
    
    private void LoadGoals()
    {
        string filename = "GoalProgress.txt";
        var lines = File.ReadAllLines(filename).Skip(1);

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            if (parts[0] == "SimpleGoal")
            {
                bool check = bool.Parse(parts[4]);

                SimpleGoal sg = new SimpleGoal(parts[1], parts[2], parts[3]);
                sg.SetIsComplete(check);
                _goals.Add(sg);
                
            }
            else if (parts[0] == "EternalGoal")
            {
                EternalGoal eg = new EternalGoal(parts[1], parts[2], parts[3]);
                _goals.Add(eg);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                int target = int.Parse(parts[4]);
                int bonus = int.Parse(parts[5]);
                int amount = int.Parse(parts[6]);

                ChecklistGoal cg = new ChecklistGoal(parts[1], parts[2], parts[3], target, bonus);
                cg.SetAmountCompleted(amount);
                _goals.Add(cg);
            }
        }
    }
}