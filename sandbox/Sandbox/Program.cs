using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Sandbox Project.");
        Console.WriteLine("");
        Console.WriteLine("What is your name? ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello {name}");
        if (name == "Diego")
        {
            Console.WriteLine("Welcome boss");
        }
    }
}