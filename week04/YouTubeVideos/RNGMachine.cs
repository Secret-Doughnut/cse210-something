using System.Globalization;

public class RNGMachine
{

    private List<string> VideoTiles = new List<string>
    {
        "This book can do what?!",
        "You have never seen a swimming pool quite like this...",
        "10 tips on how to improve your battery life!",
        "How to come up with unqiue names for your OCs",
        "I collected every single amiibo... besides ONE!",
        "How to come up with fake YouTube video titles!",
        "The difference between double and single quotes",
        "Last to leave the pit earns 10 million dollars!",
        "How to NEVER forget commas in a list again!",
        "Pizza Sticks just dropped a new flavor!"
    };
    private List<string> Authors = new List<string>
    {
        "Ilovepizza",
        "Artphones",
        "The Nerd Guy",
        "Darkness Blade",
        "Pink Doughnut",
        "The MASTER of ALL",
        "The Status Quo",
        "Pizza Sticks",
        "Jessica Shell",
        "Jennifer Oxtin"
    };
    private List<string> CommentText = new List<string>
    {
        "Yo! This video rules!",
        "'Oh, I won't do that.' Does it the very next scene.",
        "Nice video!",
        "I really liked the part at 1:03",
        "first",
        "lol",
        "A really cool detail is that the birds in that game aren't perfectly in sync with each other.",
        "The moon",
        "I just noticed that you had a Pikmin amiibo there. That's really cool!",
        "second",
        "not first",
        "Orange."
    };

    Random random = new Random();
    //My random machine for all of my functions!

    public string RandomTitle()
    {
        string title = "";
        int number = random.Next(0, 10);
        title = VideoTiles[number];

        return title;
    }

    public string RandomAuthor()
    {
        string author = "";
        int number = random.Next(0, 10);
        author = Authors[number];

        return author;
    }

    public int RandomLength()
    {
        int length = random.Next(2, 501);
        
        return length;
    }

    public string RandomComment()
    {
        string comment = "";
        int number = random.Next(0, 12);
        comment = CommentText[number];

        return comment;
    }

    public int RandomNumber()
    {
        int number = random.Next(3, 5);

        return number;
    }
}