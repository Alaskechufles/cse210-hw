using System.Security.Cryptography.X509Certificates;

public class PromptGenerator
{
    public List<string> _prompt = new List<string>{
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "What was the most challenging part of my day?",
        "What did I learn today?",
        "What made me smile or laugh today?",
        "What is one thing I accomplished today?",
        "What is something new I tried today?",
        "How did I take care of myself today?",
    };
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompt.Count);
        return _prompt[index];
    }
}