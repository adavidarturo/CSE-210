using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    // Initialize list with prompts
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area")
    {
        _prompts = new List<string>
        {
            "\n --- Who are people that you appreciate?\n",
            "\n --- What are personal strengths of yours?\n",
            "\n --- Who are people that you have helped this week?\n",
            "\n --- When have you felt the Holy Spirit this month?\n",
            "\n --- Who are some of your personal heroes?\n"
        };
    }

    // Method to get a random prompt
    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    // Method to get a written list of from user
    private List<string> GetListFromUser()
    {
        List<string> items = new List<string>(); // New "items" list
        Console.WriteLine($"You have {_duration} seconds: ");
        DateTime startTime = DateTime.Now; // Optain actual Now
        while (true)
        {
            // If DateTime.Now - startTime in seconds is major or equal than _duration
            if ((DateTime.Now - startTime).TotalSeconds >= _duration)
            {
                break;
            }
            Console.Write("> "); 
            string item = Console.ReadLine(); // Optain "item" strings
            items.Add(item); // Add each item to the "items" list
        }
        return items; // Save "items" list
    }
    
    // Method to Run all Listing Activity methods 
    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("You may begin in: ");
        ShowCountDown(5);
        List<string> items = GetListFromUser();
        Console.WriteLine($"\nYou listed {items.Count} items!\n"); // Display "items" count
        DisplayEndingMessage();
    }
}


