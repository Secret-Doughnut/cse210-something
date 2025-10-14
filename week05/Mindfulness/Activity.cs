public class Activity
{
    private List<string> animation = new List<string>
    {
        "|",
        "/",
        "-",
        "\\",
    };

    private string _name = "Blank";
    private string _description = "Short paragraph for testing things. Yep, this will be a paragraph! A very, very short one!";
    private int _duration = 0;


    public Activity()
    {

    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.\n\n{_description}");
        Console.Write($"\nHow long, in seconds, would you like your session to be? ");
        string StringHolder = Console.ReadLine();
        _duration = int.Parse(StringHolder);
        Console.WriteLine("Get Ready...");
        ShowSpinner();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done!");
        ShowSpinner();
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner();
    }

    public void ShowSpinner()
    {
        DateTime StartTime = DateTime.Now;
        DateTime EndTime = StartTime.AddSeconds(6);

        while (DateTime.Now <= EndTime)
        {
            foreach (string item in animation)
            {
                Console.Write(item);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }

    public void ShowCountDown()
    {
        int Countdown = 4;

        while (Countdown != 0)
        {
            Console.Write(Countdown);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Countdown -= 1;
        }
    }


    public int GetDuration()
    {
        return _duration;
    }
 
    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }


}