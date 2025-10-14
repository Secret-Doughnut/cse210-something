public class ReflectingActivity : Activity
{
    Random random = new Random();
    private static List<string> _prompts = new List<string>
    {
        "Think of a time when you did something really difficult.",
        "Think of a time when people were pressuring you to do something bad, but you chose to do good."
    };
    private static List<string> _questions = new List<string>
    {
        "How did you feel when it was complete?",
        "What is your favorite thing about this experience?",
        "Were you able to see God's hand in that moment?",
        "Was there someone who helped you through that experince?"
    };

    private static int _reflectingDuration = 0;


    public ReflectingActivity()
    {

    }

    public void Run()
    {
        SetName("Reflecting");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        DisplayStartingMessage();
        _reflectingDuration = GetDuration();

        DisplayPrompt();
        DateTime StartTime = DateTime.Now;
        DateTime EndTime = StartTime.AddSeconds(_reflectingDuration);
        Console.WriteLine("");
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown();
        Console.Clear();

        while (DateTime.Now <= EndTime)
        {
            DisplayQuestions();
        }

        Console.WriteLine("");
        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        int number = random.Next(0, 2);
        string prompt = _prompts[number];
        
        return prompt;
    }

    private string GetRandomQuestion()
    {
        int number = random.Next(0, 4);
        string question = _questions[number];
        
        return question;
    }

    private void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        
        Console.WriteLine($" --- {prompt} ---\n");
        Console.Write("When you have something in mind, press enter to continue.");
        Console.ReadLine();
    }
    
    private void DisplayQuestions()
    {
        string question = GetRandomQuestion();

        Console.Write($"> {question}");
        ShowSpinner();
        Console.WriteLine("");
    }
}