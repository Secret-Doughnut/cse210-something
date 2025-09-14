using System.Security.Cryptography.X509Certificates;

public class PromptGenerator
{
    public List<string> _Prompts = new List<string>()
    {
        "What is something cool that happened recently?",
        "If you were going to turn part of your day into a video game; what part would you choose?",
        "What is something you wished you did better today?",
        "If you were to describe your day with a song or two, which song(s) would you choose?",
        "Even if it's small, what's one of your favorite moments from today?"
    };

    public string GetRandomPrompt()
    {
        Random Idea = new Random();
        int Number = Idea.Next(_Prompts.Count);
        string RandomPrompt = _Prompts[Number];

        return RandomPrompt;
    }
}