/* I used the Newtonsoft library to save the entries in JSON format and added the ability to record the location where the event occurred. */

using Newtonsoft.Json;
using System;



class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        Console.WriteLine("Hello World! This is the Journal Project.");
        bool useProgram = true;
        while (useProgram == true)
        {
            Console.WriteLine("Please select one of the following choises");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");
            string option = Console.ReadLine();

            if (option == "1")
            {
                Entry entry = new Entry();
                entry._date = DateTime.Now.ToShortDateString();
                entry._promptText = promptGenerator.GetRandomPrompt();
                Console.WriteLine(entry._promptText);
                entry._entryText = Console.ReadLine();
                Console.WriteLine("Where did it happen?");
                entry._place = Console.ReadLine();
                journal.AddEntry(entry);
            }
            else if (option == "2")
            {
                journal.DisplayAll();
            }
            else if (option == "3")
            {
                Console.Write("Enter filename to load: ");
                string loadFile = Console.ReadLine();
                journal.LoadFromFile(loadFile);
            }
            else if (option == "4")
            {
                Console.Write("Enter filename to save: ");
                string saveFile = Console.ReadLine();
                journal.SaveToFile(saveFile);
            }
            else if (option == "5")
            {
                useProgram = false;
            }
            else
            {
                Console.WriteLine("Please, choose a valid option.");
            }


        }

    }
}