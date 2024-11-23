using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args) 
    {
        // New instance with the scripture Reference 
        Reference reference = new Reference("Jhon",3 ,16);
        // New instance with the "reference" and the text 
        Scripture scripture = new Scripture(reference, "For God so loved the world, that he gave his only Son, that whoever believes in him should not perish but have eternal life");
        
        bool running = true;
        int attempts = 0;

        while (running) // Execute the loop
        {
            // Use the Clear() function to clean the console 
            Console.Clear();
            // Display the "scripture" with the GetDisplayText() method
            Console.WriteLine(scripture.GetDisplayText()); 
            // Show the attempts
            Console.WriteLine($"\nAttempt: {attempts}"); 
            // Guiding message 
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit."); 
            string input = Console.ReadLine(); // Storage the user "input"

            // If the user writes "quit" 
            if (input.ToLower() == "quit")
            {
                running = false; // Stop the loop
            }
            else
            {
                // Else, if the "scripture" is all hidden
                if (scripture.IsCompletelyHidden()) 
                {
                    running = false; // Stop the loop
                }
                else 
                {
                    // Else continue hiding 3 by 3
                    scripture.HideRandomWords(3);

                    // If the "scripture" is all hidden
                    if (scripture.IsCompletelyHidden())
                    {
                        running = false; // Stop the loop 
                    }
                }
            }
            attempts++;
        }
        Console.Clear(); // Clean all again
        Console.WriteLine(scripture.GetDisplayText()); // Show the final "_" strings 
        Console.WriteLine("\n- All words hidden! Program finished."); // End message
    }
}