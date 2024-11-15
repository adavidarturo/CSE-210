using System;
using System.Collections.Generic;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main() // Main method 
    {
        Journal journal = new Journal(); // Open journal object
        PromptGenerator promptGenerator = new PromptGenerator(); // Open promptGenerator object
        
        bool running = true; // Declare a bool variable as running = True
        while (running) // While running is true

        {
            // Display options
            Console.WriteLine("Please select one of the following options:"); 
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            
            // Declare "choice" variable to storage a string input 
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                WriteEntry(journal, promptGenerator); // Display the journal and promptGenerator
            }
            else if (choice == "2")
            {
                journal.DisplayAllEntries(); // Call the DisplayAllEntries() method from journal
            }
            else if (choice == "3")
            {
                LoadJournal(journal); // Call the LoadJournal() method from Program
            }
            else if (choice == "4")
            {
                SaveJournal(journal); // Calls the SaveJournal() method from Program
            }
            else if (choice == "5")
            {
                running = false; // The running variable is false
            }
            else
            {
                Console.WriteLine("Invalid choice, please try again.");
            }
        }
    }

    // Method to write new entries in journal
    static void WriteEntry(Journal journal, PromptGenerator promptGenerator)
    {
        // Open "prompt" with the GetRandomPrompt() method from PromptGenerator object
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("- "); // Open as "- "
        string entryText = Console.ReadLine(); // Open "entryText" to storage the answer

        // Open "entry" instance with the 3 values (DateTime.Now, prompt, entryText)
        Entry entry = new Entry(DateTime.Now, prompt, entryText);
        journal.AddEntry(entry); // Add the entry instance to journal with AddEntry() method 
    }

    // Method to provite the filename and execute the SaveToFile() method 
    static void SaveJournal(Journal journal)
    {
        Console.Write("Enter filename to save: ");
        string filename = Console.ReadLine(); // Declare "filename" variable to storage the Name
        journal.SaveToFile(filename); // Apply on filename the SaveToFile() method 
    }

    // Method to compare the filename executing LoadFromFile() method
    static void LoadJournal(Journal journal)
    {
        Console.Write("Enter filename to load: ");
        string filename = Console.ReadLine(); // Declare "filename" variable to storage the Name
        journal.LoadFromFile(filename); // Apply on filename the LoadFromFile() method 
    }
}


