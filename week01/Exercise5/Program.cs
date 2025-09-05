using System;
using System.Formats.Asn1;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string Name = Console.ReadLine();
            return Name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string Catcher = Console.ReadLine();
            int Number = int.Parse(Catcher);
            return Number;
        }

        static double SquareNumber(int Number)
        {
            double Answer = Number * Number;
            return Answer;
        }

        static void DisplayResults(string Name, double Answer)
        {
            Console.WriteLine($"{Name}, the square of your number is {Answer}");
        }

        DisplayWelcome();
        string Name = PromptUserName();
        int Number = PromptUserNumber();
        double Answer = SquareNumber(Number);
        DisplayResults(Name, Answer);

    }
}