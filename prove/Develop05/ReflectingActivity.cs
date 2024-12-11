using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private List<string> _prompts; 
    private List<string> _questions;

    // Initialize lists with the respective prompts
    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strenght and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>
        {
            "> Think of a time when you stood up for someone else: \n",
            "> Think of a time when you did something really difficult: \n",
            "> Think of a time when you helped someone in need: \n",
            "> Think of a time when you did something truly selfless: \n"
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when you were done?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    // Method to get the Random Prompt
    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index]; // Save the choosen index 
    }
    
    // Method to get the Random Question 
    private string GetRandomQuestion(List<string> availableQuestions) // Parameter for available questions
    {
        Random random = new Random();
        int index = random.Next(availableQuestions.Count); // Choose an index
        string question = availableQuestions[index];

        availableQuestions.RemoveAt(index); // Remove the index from the "availableQuestions" list
        return question; // Save question
    }
    
    // Method to Display the Prompt and indications
    private void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt: \n");
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine("When you have something in mind, press enter to continue. ");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
    }

    // Method to Display Random Questions
    private void DisplayQuestions()
    {
        List<string> availableQuestions = new List<string>(_questions); // Create a new availableQuestions list
        int timePerQuestion = 5; // Fixed time per question
        int totalDuration = 0; 

        // While the condition is true
        while ( totalDuration + timePerQuestion <= _duration && availableQuestions.Count > 0)
        {
            Console.Write(GetRandomQuestion(availableQuestions)); // Get a random question
            ShowSpinner(timePerQuestion); // Show 5 seconds
            totalDuration += timePerQuestion; // Increase the "totalduration" untill it's more than _duration
        }
    }

    // Method to Run all Reflecting Activity methods 
    public override void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        DisplayPrompt();

        DisplayQuestions();
        DisplayEndingMessage();
    }
}


