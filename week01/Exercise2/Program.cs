using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage: ");
        string BoringGrade = Console.ReadLine();
        int Grade = int.Parse(BoringGrade);
        string Letter = "Testing";


        if (Grade >= 90)
        {
            Letter = "A";
        }
        else if (Grade >= 80)
        {
            Letter = "B";
        }
        else if (Grade >= 70)
        {
            Letter = "C";
        }
        else if (Grade >= 60)
        {
            Letter = "D";
        }
        else if (Grade < 60)
        {
            Letter = "F";
        }
        else
        {
            Console.WriteLine("I'm sorry, but we got an error.");
        }

        Console.WriteLine($"Your letter grade is '{Letter}'");

        if (Grade >= 70)
        {
            Console.Write("Congratulations! You passed!");
        }
        else if (Grade < 70)
        {
            Console.Write("Aww... You got under a passing grade. I bet you'll do next time! Keep trying!");
        }
    }
}