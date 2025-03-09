using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, what is your grade percentage? ");
        string grade_percent = Console.ReadLine();
        int grade_percent_num = int.Parse(grade_percent);
        string sign;

        string grade_letter;

        if (grade_percent_num >= 90)
        {
            grade_letter = "A";
        }
        else if (grade_percent_num >= 80)
        {
            grade_letter = "B";
        }
        else if (grade_percent_num >= 70)
        {
            grade_letter = "C";
        }
        else if (grade_percent_num >= 60)
        {
            grade_letter = "D";
        }
        else
        {
            grade_letter = "F";
        }
        if (grade_percent_num % 10 >= 7)
        {
            sign = "+";
            if (grade_letter == "A" || grade_letter == "F")
            {
                sign = "";
            }
        }
        else if (grade_percent_num % 10 <= 3)
        {
            sign = "-";
            if (grade_letter == "F")
            {
                sign = "";
            }
        }
        else
        {
            sign = "";
        }
        Console.WriteLine($"Your grade is {grade_letter}{sign}");

    }
}