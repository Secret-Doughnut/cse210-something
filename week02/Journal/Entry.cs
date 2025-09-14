using System;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public string _Date = "";
    public string _PromptText = "";
    public string _EntryText = "";

    public string _LineSpliter = "";

    public void Display()
    {
        DateTime now = DateTime.Today;
        _Date = $"Date: {now:MM/dd/yyyy}";
        _EntryText = $"{_Date} \nPrompt: {_PromptText} \nEntry: {_EntryText} \n{_LineSpliter}";
        Journal EntrySender = new Journal();
        EntrySender.AddEntry(_EntryText);
    }
}