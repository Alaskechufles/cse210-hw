public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity()
    {
        _name = "Reflecting Activity";
        _description = "This activity helps you reflect on times when you showed strength or resilience";
        _prompts = new List<string> {
            "Think of a time you overcame a challenge.",
            "Remember a moment you helped someone in need.",
            "Reflect on a time you learned something new."
        };

        _questions = new List<string> {
            "Why was this experience meaningful?",
            "What did you learn from it?",
            "How can you apply it in the future?"
        };

    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
        ShowSpinner(5);
    }
    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        return _prompts[rnd.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        Random rnd = new Random();
        return _questions[rnd.Next(_questions.Count)];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"{GetRandomPrompt()}");
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();
    }

    public void DisplayQuestions()
    {
        Console.Clear();
        Console.WriteLine("Now ponder on each of the following questions:");

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        int index = 0;

        while (DateTime.Now < endTime && index < _questions.Count)
        {
            Console.WriteLine($"> {_questions[index]}");
            ShowSpinner(5);
            index++;
        }
    }
}