using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Type your note: ");
        string userInput = Console.ReadLine();
        float number = int.Parse(userInput);
        
        if (number >= 90) 
        {
            Console.WriteLine("Your grade is: A ");
        }
        else if (number >= 80)
        {
            Console.WriteLine("Your grade is: B ");
        }
        else if (number >= 70)
        {
            Console.WriteLine("Your grade is: C ");
            Console.WriteLine("You passed the course! ");
        }
        else if (number >= 60)
        {
            Console.WriteLine("Your grade is: D ");
            Console.WriteLine("You will do it better next time ");
        }
        else if (number < 60)
        {
            Console.WriteLine("Your grade is: F ");
            Console.WriteLine("You will do it better next time ");
        }

    }
}