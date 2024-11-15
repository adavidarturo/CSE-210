using System;
using System.Collections.Generic;

public class Entry 
{
    // Declare 3 characteristics
    public DateTime _date; // _date to storage DateTime
    public string _messageText; // _messageText to storage question 
    public string _entryText; // _entryText to storage user answer

    // Constructor to initialize characteristics
    public Entry(DateTime date, string messageText, string entryText) 
    {
        _date = date;
        _messageText = messageText;
        _entryText = entryText;
    }
    
    // Method to display the Entry class
    public void Display()
    {
        Console.WriteLine($"Date: {_date.ToString("MM-dd-yyyy")} - Prompt: {_messageText} - Answer: {_entryText}");
        // .ToString to convert _date to string
    }
}