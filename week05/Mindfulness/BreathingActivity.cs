public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "In this activity we will breathe slowly to relax.";
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.Write("Enter duration in seconds greater than 6: ");
        _duration = int.Parse(Console.ReadLine());
        double _loopTime = _duration / 6;

        for (int i = 0; i < Math.Floor(_loopTime); i++)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(3);
            Console.WriteLine("Breathe out...");
            ShowCountDown(3);
        }
        ShowSpinner(4);
        DisplayEndingMessage();
        ShowSpinner(4);
    }
}