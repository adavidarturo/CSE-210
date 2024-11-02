using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        DisplayResult();
    }
            static void DisplayWelcome()
            {
            Console.WriteLine("Welcome to the program!");
            }

            static string PromptUserName()
            {
                Console.Write("Enter your name: ");
                return Console.ReadLine();
            }

            static int PromptUserNumber()
            {
                Console.Write("Enter your favorite number: ");
                return int.Parse(Console.ReadLine());
            }

            static int SquareNumber(int number)
            {
                return number * number;
            }

            static void DisplayResult()
            {
                DisplayWelcome();
                string name = PromptUserName();
                int number = PromptUserNumber();
                int square = SquareNumber(number);
                Console.WriteLine($"{name}, the square of your number is {square}.");
            }
}