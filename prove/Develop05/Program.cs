using System;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            string choice = Console.ReadLine();

            Activity activity;

            if (choice == "1") 
            {
                activity = new BreathingActivity(); // Execute Breathing A.
            }
            else if (choice == "2")
            {
                activity = new ReflectingActivity(); // Execute Reflecting A.
            }
            else if (choice == "3")
            {
                activity = new ListingActivity(); // Execute Listing A.
            }
            else if (choice == "4")
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                Console.WriteLine("Press Enter to continue");
                Console.ReadLine();
                continue;
            }
            activity.Run(); // Execute the choosen Run() method 
        }
    }
}

