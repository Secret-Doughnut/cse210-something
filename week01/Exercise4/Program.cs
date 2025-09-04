using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        List<int> Numbers = new List<int>();
        string Check = "";
        int sum = 0;
        int BiggestNumber = 0;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (Check != "yes")
        {
            Console.Write("Enter number: ");
            string Catcher = Console.ReadLine();
            int ListNumber = int.Parse(Catcher);

            if (ListNumber != 0)
            {
                Numbers.Add(ListNumber);
            }
            else if (ListNumber == 0)
            {
                Check = "yes";
            }
            else
            {
                Console.Write("Something went wrong)");
            }
        }

        foreach (int Number in Numbers)
        {
            sum += Number;
            if (Number > BiggestNumber)
            {
                BiggestNumber = Number;
            }
        }
        double AverageAnswer = Numbers.Count;
        double Average = sum / AverageAnswer;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {Average}");
        Console.WriteLine($"The largest number is: {BiggestNumber}");
    }
}