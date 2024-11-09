using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {

        int addItem = -1;
        List <int> numbersList = new List<int>();
        int sum = -1;
        int largest = int.MinValue;

        Console.WriteLine("Enter alist of numbers, type 0 when finished. ");

        while (addItem != 0)
        {
            Console.Write("Enter a number: ");
            addItem = int.Parse(Console.ReadLine());
            numbersList.Add(addItem);
        }

            foreach (int i in numbersList)
            {
                sum += i;

                if (i > largest)
                {
                    largest = i;
                }
            }

            float average = sum / numbersList.Count;

            Console.WriteLine($"The total sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {largest}");

    }

}