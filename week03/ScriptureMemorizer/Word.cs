using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

public class Word
{
    private List<string> _words = new List<string>();

    private static string _scripture = "";

    private int _rngNumber = 0;

    private bool _isHidden = false;

    public Word(string text)
    {
        WordListSpliter(text);
        HideWord();
        Scripture helper = new Scripture();
        helper.SetScripture(_scripture);
    }

    private void WordListSpliter(string text)
    {
        string[] _spliter = text.Split(" ");
        int _wordCounter = _spliter.Count();

        _rngNumber = _wordCounter;

        foreach (string item in _spliter)
        {
            _words.Add(item);
        }
    }
    private void HideWord()
    {
        int helpful = 3;
        Random RandomNumber = new Random();


        while (helpful != 0)
        {
            int RandomTesting = RandomNumber.Next(_rngNumber);
            UnderscoreReplacer(RandomTesting);
            helpful -= 1;
        }

        _scripture = String.Join(" ", _words);
    }

    private void UnderscoreReplacer(int number)
    {
        string underscore = "_";
        int symbolCount = _words[number].Count();
        symbolCount -= 1;

        while (symbolCount != 0)
        {
            underscore += "_";
            symbolCount -= 1;
        }

        _words[number] = underscore;
    }

    // I put this in the Word class, instead of the Scripture class,
    // because I had to separate the words and that felt
    // more like the Word class' job.
    public bool IsCompletelyHidden()
    {
        int counter = 0;
        bool quickCheck = false;

        foreach (string item in _words)
        {
            quickCheck = item.Contains("_");

            if (quickCheck == true)
            {
                counter += 1;
            }

            if (counter == _rngNumber)
            {
                _isHidden = true;
            }
        }
        return _isHidden;
    }


    // private void RandomNumberGenerator()
    // {
    //     Random RandomNumbers = new Random();
    //     int RandomTesting = RandomNumbers.Next(_RNGnumber);
    // }

    // public void WordTest()
    // {
    //     HideWord();

    //     foreach (string item in _Words)
    //     {
    //         Console.WriteLine($"Hello from WordTest! {item}");
    //     }
    // }
}