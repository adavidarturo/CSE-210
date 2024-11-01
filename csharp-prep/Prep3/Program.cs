using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guess = -1;
        int attempts = 0;
        Console.WriteLine($"What is the magic number?");

        while (magicNumber != guess)
        {
            Console.Write("What is your guess? ");
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
        Console.WriteLine($"Congratulation! the magic number is {magicNumber}");
        Console.WriteLine($"It took you {attempts} attempts");
    }
}