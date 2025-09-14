// I have added some empty lines to make things
// easier to read and I also added a little warning
// when saving the entries to a file.


using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        string Helpful = "";

        while (Helpful != "Yes")
        {
            Choices StartUp = new Choices();
            StartUp.Display();
            string Testing = Console.ReadLine();

            if (Testing == "1")
            {
                Entry EntryHolder = new Entry();
                PromptGenerator Test = new PromptGenerator();
                string _PromptText = Test.GetRandomPrompt();
                EntryHolder._PromptText = _PromptText;
                Console.WriteLine(_PromptText);
                Console.Write("> ");
                EntryHolder._EntryText = Console.ReadLine();
                EntryHolder.Display();

            }
            else if (Testing == "2")
            {
                Journal Viewer = new Journal();
                Viewer.DisplayAll();
                Console.Write("Press enter to continue ");
                Console.ReadLine();
            }
            else if (Testing == "3")
            {
                Journal FileReader = new Journal();
                Console.WriteLine("What file do you want to load from?");
                string file = Console.ReadLine();
                FileReader.LoadFromFile(file);
                Console.Write("Press enter to continue ");
                Console.ReadLine();
            }
            else if (Testing == "4")
            {
                Console.WriteLine("");
                Console.WriteLine("Warning: After entries are saved in file, they will be removed from memory. Only the saved file will remain.");
                Console.WriteLine("");
                Console.WriteLine("What do you want the file name to be called?");
                Console.WriteLine("[Name You Want].txt");
                string File = Console.ReadLine();
                Journal FileSender = new Journal();
                FileSender.SaveToFile(File);
            }
            else if (Testing == "5")
            {
                Helpful = "Yes";
            }
        }
    }
}