using Newtonsoft.Json;

public class Journal
{

    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);

    }
    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        string json = JsonConvert.SerializeObject(_entries, Formatting.Indented);
        File.WriteAllText(file, json);
    }
    public void LoadFromFile(string file)
    {
        if (File.Exists(file))
        {
            string json = File.ReadAllText(file);
            _entries = JsonConvert.DeserializeObject<List<Entry>>(json);
        }
        else
        {
            Console.WriteLine("File not found");
        }
    }
}