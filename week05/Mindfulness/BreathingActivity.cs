public class BreathingActivity : Activity
{
    private int _breathingDuration = 0;

    public BreathingActivity()
    {

    }

    public void Run()
    {
        SetName("Breathing");
        SetDescription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        DisplayStartingMessage();
        _breathingDuration = GetDuration();

        DateTime StartTime = DateTime.Now;
        DateTime EndTime = StartTime.AddSeconds(_breathingDuration);
        Console.WriteLine("");

        while (DateTime.Now <= EndTime)
        {
            Console.Write("Breathe in...");
            ShowCountDown();
            Console.Write("\nNow breathe out...");
            ShowCountDown();
            Console.WriteLine("\n");
        }
        
        DisplayEndingMessage();
    }
}