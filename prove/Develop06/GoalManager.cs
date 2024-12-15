using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals; // Main Goals list
    private int _score; // Main Score

    // Initialize variables
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start() // Method to Start the program
    {
        while (true)
        {
            Console.Clear();
            DisplayPlayerInfo(); // Display the current score

            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("\nSelect a choice from the menu: ");

            string choice = Console.ReadLine(); // Execute the user choice
            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {         
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            else if (choice == "6")
            {
                return;
            }
            else
            {
            Console.WriteLine("Invalid choice. Press any key to continue...");
            Console.ReadKey();
            }
        }
    }
    
    // Method to always show the current score
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}\n");
    }

    // Method to display enumeration of each goal
    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.Count; i++) // The "i" variable will be less than the goals count to increase each time
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}"); // Increase "i" with 1 each time
        }
    }

    // Method to Display all content and features
    public void ListGoalDetails()
    {
        Console.Clear();
        ListGoalNames(); // Use the same past enumeration
        Console.WriteLine("Press any key to return to the menu...");
        Console.ReadKey();
    }
    
    // Method to create a new kind of goal
    public void CreateGoal()
    {
        Console.WriteLine("\n1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("\nChoose a goal type: ");
        string choice = Console.ReadLine();

        Console.Write("- Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("- Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("- Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice) // I used (Microsoft Copilot) to retyped this switch for better readability and clarity 
        // instead of using "if" statements.
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points)); // Add Simple Goal instance
                break;

            case "2":
                _goals.Add(new EternalGoal(name, description, points)); // Add Eternal Goal instance
                break;

            case "3":
                Console.Write("- Enter how many times you have to complete that task: "); 
                int target = int.Parse(Console.ReadLine()); // Add target 

                Console.Write("- Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine()); // Add bonus

                _goals.Add(new ChecklistGoal(name, description, points, target, bonus)); // Add Checklist Goal instance and (target, bonus)
                break;

            default:
                Console.WriteLine("Invalid choice."); // Any other choice
                break;
        }
    }

    // Method to storage an accomplish goal
    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1; // Subtract index -1 

        if (index >= 0 && index < _goals.Count) // If the index is less than 0 and the goals count
        {
            Goal goal = _goals[index]; // Save the index,
            int pointsEarned = goal.RecordEvent(); // Save points and the string message
            _score += pointsEarned; // Total: _score incremented
            Console.WriteLine($"Congratulations! This time you earned: {pointsEarned} points!");
            Console.WriteLine($"Your total is: {_score}!");
        }
        else
        { 
            Console.WriteLine("Invalid goal number.");
        }
        Console.WriteLine("\nPress any key to return to the menu...");
        Console.ReadKey();
    }

    // Method to save the goal to a file 
    public void SaveGoals() 
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine(); 

        using (StreamWriter writer = new StreamWriter(filename)) // New "writer" instance
        {
            writer.WriteLine(_score); // Write the "_score"
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation()); // And each String Representations
            }
        }
        Console.WriteLine("Goals saved successfully. Press any key to return to the menu..."); // Confirmation meessage
        Console.ReadKey();
    }

    // Method to load the goals to use them again
    public void LoadGoals()
    {
    Console.Write("What is the filename for the goal file? ");
    string filename = Console.ReadLine(); // Storage filename

    if (!File.Exists(filename)) // I the file dont existe
    {
        Console.WriteLine("File not found. Press any key to return to the menu...");
        Console.ReadKey();
        return;
    }

    _goals.Clear(); // Remove all elements from the list
    string[] lines = System.IO.File.ReadAllLines(filename); // Declare a "lines" array to read all lines in the file
    _score = int.Parse(lines[0]); // 

    for (int i = 1; i < lines.Length; i++) // The "i" variable will be less than the lines length and will increment each time
    {
        string line = lines[i];
        string[] parts = line.Split('|'); // Divide each "parts" with "|"

        string goalType = parts[0]; 
        string name = parts[1];
        string description = parts[2];
        int points = int.Parse(parts[3]); // Convert to (int)

        switch (goalType) // Choose a "goalType"
        {
            case "SimpleGoal": 
                bool isComplete = bool.Parse(parts[4]); // Convert to (int)
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points); // New simpleGoal instance

                simpleGoal.SetCompletion(isComplete); // Set the completion of the simpleGoal
                _goals.Add(simpleGoal); // Add to the list
                break;

            case "EternalGoal":
                _goals.Add(new EternalGoal(name, description, points)); // Add to the list
                break;

            case "ChecklistGoal":
                int amountCompleted = int.Parse(parts[4]); // Convert special parts to (int)
                int target = int.Parse(parts[5]);
                int bonus = int.Parse(parts[6]);

                ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus); // New checklistGoal instance
                checklistGoal.SetAmountCompleted(amountCompleted); // Set the completion of all checklistGoals
                _goals.Add(checklistGoal); // Add to the list
                break;
        }
    }

    Console.WriteLine("Goals loaded successfully. Press any key to return to the menu..."); // Confirmation meessage
    Console.ReadKey();

    }
}










