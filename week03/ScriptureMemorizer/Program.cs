using System;
using System.Formats.Asn1;
using System.Runtime.InteropServices;

class Program
{
    // I have added the functionality for the user
    // to enter whatever scripture they want!

    static void Main(string[] args)
    {
        string helpful = "Yes";

        Console.WriteLine("Please input a scripture: ");
        string scriptureFromUser = Console.ReadLine();

        Console.WriteLine("Please enter the reference: ");
        string referenceFromUser = Console.ReadLine();

        Scripture scripture = new Scripture(scriptureFromUser);
        Reference reference = new Reference(referenceFromUser);

        while (helpful == "Yes")
        {
            Console.Clear();
            reference.Display();
            scripture.Display();

            Console.WriteLine("");
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            string Quit = Console.ReadLine();

            if (Quit == "quit")
            {
                helpful = "No";
            }
            else
            {
                string NewScripture = scripture.GetScripture();
                Word w = new Word(NewScripture);
                bool Checker = w.IsCompletelyHidden();

                if (Checker == true)
                {
                    Console.Clear();
                    reference.Display();
                    scripture.Display();
                    Console.WriteLine("");
                    Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
                    helpful = "No";
                }
            }
        }

    }
}