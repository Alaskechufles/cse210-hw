using System;

class Program
{
    static void Main(string[] args)
    {
        string try_again = "yes";
        while (try_again == "yes")
        {
            Random random_number = new Random();
            int magic_number = random_number.Next(1, 100);
            Console.WriteLine("Try to guess the magic number: ");
            string guess_number;
            int int_guess_number;
            bool game = true;
            while (game == true)
            {
                guess_number = Console.ReadLine();
                int_guess_number = int.Parse(guess_number);
                if (int_guess_number > magic_number)
                {
                    Console.WriteLine("Lower");
                    Console.WriteLine("What is your guess? ");
                }
                else if (int_guess_number < magic_number)
                {
                    Console.WriteLine("Higher");
                    Console.WriteLine("What is your guess? ");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    game = false;
                }
            }
            Console.WriteLine("Try again? yes / no ");
            string response = Console.ReadLine();
            try_again = response;
            if (try_again != "yes")
            {
                Console.WriteLine("Thanks for playing!");
            }
        }
    }
}