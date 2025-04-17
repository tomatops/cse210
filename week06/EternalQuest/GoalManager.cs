public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
        _goals.Clear();
    }

    // Runs the menu
    public void Start()
    {
        int choice = 0;
        
        while (choice != 6)
        {
            Console.WriteLine("====================");
            DisplayPlayerInfo();
            Console.WriteLine("--------------------");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create a new goal");
            Console.WriteLine("2. Display goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit");
            Console.Write("> ");
            choice = int.Parse(Console.ReadLine());

            Console.Clear();

            // 1. Create a new goal
            if (choice == 1)
            {
                CreateGoal();
            }

            // 2. Display goals
            else if (choice == 2)
            {
                Console.Clear();
                Console.WriteLine("====================");
                Console.WriteLine("Your goals:");

                ListGoalDetails();

                Console.WriteLine();
                
                Console.WriteLine("Press Enter to continue.");
                Console.ReadLine();
                Console.Clear();
            }

            // 3. Save goals
            else if (choice == 3)
            {
                SaveGoals();
            }

            // 4. Load goals
            else if (choice == 4)
            {
                LoadGoals();
            }

            // 5. Record event
            else if (choice == 5)
            {
                Console.Clear();
                Console.WriteLine("====================");
                Console.WriteLine("Your goals:");

                List<int> indexes = new List<int>();

                for (int i = 1; i < (_goals.Count + 1); i++)
                {
                    indexes.Add(i);
                }

                var goalsList = indexes.Zip(_goals, (index, goal) => $"{index}. {goal.GetDetailsString()}");

                foreach (var goal in goalsList)
                {
                    Console.WriteLine(goal);
                }

                RecordEvent();
            }

            // 6. Quit
            else if (choice == 6)
            {
                Console.WriteLine("Thank you for using the Eternal Quest Program.");
            }

            else
            {
                Console.WriteLine("====================");
                Console.WriteLine("Please choose a valid action.");
                Console.WriteLine("====================");
            }
        }
    }

    // Displays player's current score
    public void DisplayPlayerInfo()
    {
        if (_score == 1)
        {
            Console.WriteLine($"You have {_score} point.");
        }
        
        else
        {
            Console.WriteLine($"You have {_score} points.");
        }
    }

    // Lists the names of each of the goals
    public void ListGoalNames()
    {
    }

    // Lists the details of each goal
    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            string checkbox;
        
            if (goal.IsComplete() == true)
            {
                checkbox = "[X]";
            }
        
            else
            {
                checkbox = "[ ]";
            }

            Console.Write(checkbox);
            Console.Write($" {goal.GetDetailsString()}");
            Console.WriteLine();
        }
    }

    // Asks the user for information about a new goal and adds it to a list
    public void CreateGoal()
    {
        int choice1 = 0;

        while (choice1 != 4)
        {
            Console.WriteLine("====================");
            Console.WriteLine("Choose a goal type:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("4. Return to menu");
            Console.Write("> ");
            choice1 = int.Parse(Console.ReadLine());

            if (choice1 == 1)
            {
                Console.WriteLine();
                Console.Write("Name of goal: ");
                string name = Console.ReadLine();
                Console.Write("Description of goal: ");
                string description = Console.ReadLine();
                Console.Write("Amount of points associated with the goal: ");
                string points = Console.ReadLine();

                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);

                _goals.Add(simpleGoal);

                Thread.Sleep(500);
                Console.Clear();
            }

            else if (choice1 == 2)
            {
                
            }

            else if (choice1 == 3)
            {
                
            }

            else if (choice1 == 4)
            {
                Console.Clear();
                Start();
            }

            else
            {
                Console.WriteLine("====================");
                Console.WriteLine("Please choose a valid action.");
                Console.WriteLine("====================");
            }
        }
    }

    // Asks the user which goal they have done and records the event
    public void RecordEvent()
    {
        Console.WriteLine();
        Console.WriteLine("What goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine());
        int listIndex = index - 1;

        _goals[listIndex].IsComplete();
        Console.WriteLine();
        Console.Write("Congratulations! You have earned ");
        _goals[listIndex].RecordEvent();
        Console.Write(" points!");
        Console.WriteLine();
    }

    // Saves the list of goals to a file
    public void SaveGoals()
    {
    }

    // Loads the list of goals from a file
    public void LoadGoals()
    {
    }
}