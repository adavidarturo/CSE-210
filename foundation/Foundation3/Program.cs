using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2024, 10, 9), 33, 6.5),
            new Cycling(new DateTime(2024, 10, 9), 44, 10.0),
            new Swimming(new DateTime(2024, 10, 9), 22, 40)
        };

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}



