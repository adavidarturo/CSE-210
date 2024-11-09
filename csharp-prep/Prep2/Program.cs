using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Type your note: ");
        string userInput = Console.ReadLine();
        float number = int.Parse(userInput);
        string letter = "";
        
        if (number >= 90) 
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (number >= 70)
        {
            Console.WriteLine("You passed the couse! ");
        }
        
        else
        {
            Console.WriteLine("You will do it better next time");
        }

    }
}