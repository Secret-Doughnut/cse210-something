using System;

class Program
{
    static void Main(string[] args)
    {
        string check = "";

        Random RandomNumber = new Random();
        int Number = RandomNumber.Next(1, 101);

            while (check == "")
        {
            Console.Write("What is your guess? ");
            string MagicGuess = Console.ReadLine();
            int Guess = int.Parse(MagicGuess);

            if (Number > Guess)
            {
                Console.WriteLine("Higher");
            }
            else if (Guess > Number)
            {
                Console.WriteLine("Lower");
            }
            else if (Number == Guess)
            {
                Console.Write("You guessed it!");
                check = "yes";
            }
            else
            {
                Console.Write("Error. Please try again.");
                check = "yes";
            }
        }
    }
}