using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    // Declare _entries list from Entry objects
    public List<Entry> _entries = new List<Entry>(); 

    // Method to add Entry objects to the _entries list
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry); // Add the entry parameter to the _entries list
    }

    // Method to display all of the Entry objects
    public void DisplayAllEntries()
    {
        foreach (Entry entry in _entries) // For each entry in the _entries list
        {
            entry.Display(); // Display the entries from Entry
        }
    }

    // Method to save all in a file "filename"
    public void SaveToFile(string filename)
    {
        // New instance of the class StreamWriter to "write" in the filename parameter 
        using (StreamWriter writer = new StreamWriter(filename)) 
        {
            foreach (Entry entry in _entries) // For each entry in the _entries list
            {
                // Write this way with "|" separators
                writer.WriteLine($"{entry._date.ToString("MM-dd-yyyy")} | {entry._messageText}| {entry._entryText}");
            }
        }
        Console.WriteLine("Journal saved successfully... ");
    }

    // Method to load and show the input data in the terminal
    public void LoadFromFile(string filename) 
    {
        if (File.Exists(filename)) // Determines if the file exists with a File.Exist() function
        {
            // Define "lines" as an array with (using System.IO.File.ReadLine() function) 
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines) // For each line in the array lines

            {
                // Declare the array "parts" dividing each line with (Split in "|")
                string[] parts = line.Split("|");

                DateTime date = DateTime.Parse(parts[0]); // date as parts 0
                string messageText = parts[1]; // messageText as parts 1
                string entryText = parts[2]; // entryText as parts 2

                // Emcapsulate in "entry" the Entry variables
                Entry entry = new Entry(date, messageText, entryText); 
                // Now add the new Entry object to the _entries list
                AddEntry(entry);
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        else // If the file doesn't exist 
        {
            Console.WriteLine("File not found.");
        }
    }
}


