using System;

class Program
{
    static void Main(string[] args)
    {
        bool Helpful = false;

        Console.Clear();
        
        while (Helpful != true)
        {
            
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start Breathing Activity");
            Console.WriteLine("  2. Start Reflecting Activity");
            Console.WriteLine("  3. Start Listing Activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            string MenuOption = Console.ReadLine();

            BreathingActivity ba = new BreathingActivity();
            ReflectingActivity ra = new ReflectingActivity();
            ListingActivity la = new ListingActivity();

            if (MenuOption == "1")
            {
                Console.Clear();
                ba.Run();
            }
            else if (MenuOption == "2")
            {
                Console.Clear();
                ra.Run();
            }
            else if (MenuOption == "3")
            {
                Console.Clear();
                la.Run();
            }
            else if (MenuOption == "4")
            {
                Helpful = true;
            }

            if (Helpful != true)
            {
                Console.Clear();   
            }
        }
    }
}