using System.ComponentModel;

public class ListingActivity : Activity
{
    private static int _count = 0;
    private static List<string> _prompts = new List<string>
    {
        "When have you felt the Holy Ghost this month?",
        "When have you seen God's hand in your life this month?",
        "When have you helped and/or served someone in the last month?",
        "When have you cast off the natural man and turned to God in the last month?"
    };
    private static List<string> _userAnswers = new List<string>();

    private static int _listingDuration = 0;



    public ListingActivity()
    {

    }

    public void Run()
    {
        SetName("Listing");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        DisplayStartingMessage();
        _listingDuration = GetDuration();

        DateTime StartTime = DateTime.Now;
        DateTime EndTime = StartTime.AddSeconds(_listingDuration);
        Console.WriteLine("");

        while (DateTime.Now <= EndTime)
        {
            string prompt = GetRandomPrompt();

            Console.WriteLine("List as many respones you can to the following prompt:");
            Console.WriteLine($" --- {prompt} ---");
            Console.Write("You may begin in: ");
            ShowCountDown();
            Console.WriteLine("");

            while (DateTime.Now <= EndTime)
            {
                Console.Write("> ");
                _userAnswers.Add(Console.ReadLine());
            }
        }

        _count = _userAnswers.Count();
        Console.WriteLine($"\nYou listed {_count} items!");
        DisplayEndingMessage();

    }

    public string GetRandomPrompt()
    {
        Random random = new Random();

        int number = random.Next(0, 4);
        string prompt = _prompts[number];

        return prompt;
    }

    public List<string> GetListFromUser()
    {
        return _userAnswers;
    }
}