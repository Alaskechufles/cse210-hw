public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity()
    {

    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Activity: {_name}\n{_description}");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You completed the Activity:{_name} \nDuration: {_duration} seconds");
        Thread.Sleep(2000);
    }
    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b \b");
        }
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i}  ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}