using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guess = -1;
        int attempts = 0;

        while (magicNumber != guess)
        {
            Console.Write("What is the magic number? ");
            guess = int.Parse(Console.ReadLine());
            attempts++;

                if (magicNumber < guess)
                 {
                     Console.WriteLine("Lower");
                 }

                if (magicNumber > guess)
                 {
                     Console.WriteLine("Higher");
                 }
        }
        Console.WriteLine($"Congratulation it took you {attempts} attempts");
    }
}