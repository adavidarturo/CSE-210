public class BreathingActivity : Activity
{
    // Constructor to use Activity attributes
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing")
    {
    }

    // Method to run the Breathing Activity
    public override void Run()
    {
        DisplayStartingMessage();

        int totalDuration = 0;
        while (totalDuration < _duration) // While the Activity duration is major 
        {
            Console.Write($"\nInhale...");
            ShowCountDown(5);
            Console.Write("\nExhale...");
            ShowCountDown(5);
            totalDuration += 10; // Increase 5 seconds inhale and  5 seconds exhale
        }
        Console.WriteLine("\n");
        DisplayEndingMessage();
    }
}


