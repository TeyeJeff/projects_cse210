using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
        _entries.ForEach(item => Console.WriteLine(item._answer));
    }

    public void SaveToFile(string fileName)
    {
        string data = "";

        foreach (Entry entry in _entries)
        {
            data += $"Date: {entry._date} - Prompt: {entry._prompt}~{entry._answer}|";
        }

        File.WriteAllText(fileName, data);
    }

    public void LoadFromFile(string filename){
        if (!File.Exists(filename))
        {
            Console.WriteLine("File does not exist");
            return;
        }
        string data = File.ReadAllText(filename);
        string[] entries = data.Split('|');

        foreach (string strEntry in entries)
        {
            if (strEntry.Trim() == "")
            {
                return;
            }
            Entry entry = new Entry();
            string[] strEntryData = strEntry.Split("~");
            entry._answer = strEntryData[1];
            string[] datePrompt = strEntryData[0].Split('-');
            entry._date = datePrompt[0].Split(':')[1];
            entry._prompt = datePrompt[1].Split(':')[1];

            _entries.Add(entry);
        }
    }
}