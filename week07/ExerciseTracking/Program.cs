using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        var activities = new List<Activity>{
            new Running(new DateTime(2025, 03, 4), 30, 3.0),
            new Cycling(new DateTime(2025, 02, 5), 30, 9.7),
            new Swimming(new DateTime(2025, 01, 6), 30, 40)
        };
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSumary());
        }
    }
}