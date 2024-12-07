using System;
using System.Threading;

public abstract class Activity
{
    protected string _name; // Name for the Activity
    protected string _description; // Description of the Activity
    protected int _duration; // Duration in seconds for the Activity

    // Initialize variables
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Method to Display the first message
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Wellcome to the {_name} Activity.\n"); 
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your session: ");
        _duration = int.Parse(Console.ReadLine()); // Choose how many seconds the Activity will take
        Console.Clear();
        Console.WriteLine("Get ready..."); 
        ShowSpinner(3);
    }

    // Method to show the end message
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!!"); 
        ShowSpinner(3);
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} activity.");
        ShowSpinner(3);
    }
    
    // Method to create the Spinner 
    public void ShowSpinner(int seconds)
    {
        int i = 0;
        while ( i < seconds) // While "i" is minor
        {
            Console.Write("/");
            Thread.Sleep(250); // Pause 250 milliseconds
            Console.Write("\b \b"); // Erase the "/" 
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b"); // Erase the "-"
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++; // Increase "i"
        }
        Console.WriteLine();
    }
    
    // Method to show a count down
    public void ShowCountDown(int seconds)
    {
        int i = seconds;
        while (i > 0) // While the index is major than 0
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i--; // Decrease "i"
        }
    }
    public abstract void Run(); // Abstract method for every other Run() method 
}




