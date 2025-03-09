using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        bool add_number = true;
        List<int> numbers = new List<int>();
        while (add_number == true)
        {
            Console.WriteLine("Enter number");
            string number = Console.ReadLine();
            if (number == "0")
            {
                add_number = false;
            }
            else
            {
                numbers.Add(int.Parse(number));
            }
        }
        int sum = numbers.Sum();
        Console.WriteLine($"The sum is: {sum}");
        double average = numbers.Average();
        Console.WriteLine($"The average is: {average}");
        int largest = numbers.Max();
        Console.WriteLine($"The largest number is: {largest}");
        numbers.Sort();
        int smallest_positive = numbers.Where(n => n > 0).Min();
        Console.WriteLine($"The smallest positive number is: {smallest_positive}");
        Console.WriteLine($"The sorted list is: ");
        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }

    }
}