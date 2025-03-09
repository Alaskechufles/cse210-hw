using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string user_name = PromptUserName();
        int user_number = PromptUserNumber();
        int square_number = SquareNumber(user_number);
        DisplayResults(user_name, square_number);

    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.WriteLine("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static int SquareNumber(int number)
    {
        int square_number = number * number;
        return square_number;
    }
    static void DisplayResults(string name, int square_number)
    {
        Console.WriteLine($"{name}, the square of your number is {square_number}");
    }
}