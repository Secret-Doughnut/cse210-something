using System.IO;
using System.Runtime.CompilerServices;

public class Journal
{
    public static List<string> _Entries = new List<string>();

    public void AddEntry(string NewEntry)
    {
        _Entries.Add(NewEntry);
    }

    public void DisplayAll()
    {
        Console.WriteLine("");
        foreach (string entry in _Entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter writer = new StreamWriter(file, append: true))
        {
            foreach (string item in _Entries)
            {
                writer.WriteLine(item);
            }
            _Entries.Clear();
        }
    }

    public void LoadFromFile(string file)
    {
        Console.WriteLine("");
        string[] lines = File.ReadAllLines(file);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}