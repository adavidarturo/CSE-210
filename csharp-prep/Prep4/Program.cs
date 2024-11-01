using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        int addItem = -1;
        List <int> numbersList = new List<int>();

        Console.WriteLine("Enter alist of numbers, type 0 when finished. ");

        while (addItem != 0)
        {
            Console.Write("Enter a number: ");
            addItem = int.Parse(Console.ReadLine());
            numbersList.Add(addItem);
        }
    
    }

}