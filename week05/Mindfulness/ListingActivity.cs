using Newtonsoft.Json;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "In this activity we will list the good things in our life.";
        _prompts = new List<string>{
            "List things you are grateful for:",
            "List people who help you feel loved:",
            "List your personal strengths:"
        };
    }
    public void Run()
    {
        DisplayStartingMessage();
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        var randomPrompt = GetRandomPromp();
        Console.WriteLine(randomPrompt);
        Console.Write("Start in: ");
        ShowCountDown(5);
        var list = GetListFromUser();
        _count = list.Count;
        Console.WriteLine($"There are {_count} items in your list.");
        Console.Write("Enter filename to save: ");
        string saveFile = Console.ReadLine();
        SaveToFile(saveFile, list, randomPrompt);
        DisplayEndingMessage();
        ShowSpinner(5);
    }
    public string GetRandomPromp()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        return $"{_prompts[index]}";
    }
    public List<string> GetListFromUser()
    {
        List<string> list = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                list.Add(item);
            }
        }
        return list;
    }
    public void SaveToFile(string file, List<string> list, string prompt)
    {

        var _entry = new { Prompt = prompt, Answers = list };
        string json = JsonConvert.SerializeObject(_entry, Formatting.Indented);


        File.WriteAllText(file, json);
    }
}