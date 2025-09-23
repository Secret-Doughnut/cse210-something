using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

public class Reference
{
    private string _book = "";

    private int _chapter = 0;

    private int _firstVerse = 0;

    private int _lastVerse = 0;

    public Reference(string reference)
    {
        Sorter(reference);
    }

    private void Sorter(string reference)
    {
        string[] spaceSpliter = reference.Split(new char[] {' ', ':'});
        int spaceCounter = spaceSpliter.Count();

        if (spaceCounter == 4)
        {
            _book = $"{spaceSpliter[0]} {spaceSpliter[1]}";
            _chapter = int.Parse(spaceSpliter[2]);
            string[] verseSpliter = spaceSpliter[3].Split("-");
            int verseCounter = verseSpliter.Count();

            if (verseCounter == 2)
            {
                _firstVerse = int.Parse(verseSpliter[0]);
                _lastVerse = int.Parse(verseSpliter[1]);
            }
            else
            {
                _firstVerse = int.Parse(verseSpliter[0]);
            }

        }
        else if (spaceCounter == 3)
        {

            _book = spaceSpliter[0];
            _chapter = int.Parse(spaceSpliter[1]);

            string[] VerseSpliter = spaceSpliter[2].Split("-");
            int VerseCounter = VerseSpliter.Count();

            if (VerseCounter == 2)
            {
                _firstVerse = int.Parse(VerseSpliter[0]);
                _lastVerse = int.Parse(VerseSpliter[1]);
            }
            else
            {
                _firstVerse = int.Parse(VerseSpliter[0]);
            }
        }

        // if (SpaceCounter == 3)
        // {
        //     _Book = $"{SpaceSpliter[0]} {SpaceSpliter[1]}";
        //     string[] ColonSpliter = SpaceSpliter[2].Split(":");
        //     _Chapter = int.Parse(ColonSpliter[0]);
        //     int VerseCounter = ColonSpliter[1].Count();

        //     if (VerseCounter == 3)
        //     {
        //         string[] DashSpliter = ColonSpliter[1].Split("-");
        //         _FirstVerse = int.Parse(DashSpliter[0]);
        //         _LastVerse = int.Parse(DashSpliter[1]);
        //     }
        //     else if (VerseCounter == 1)
        //     {
        //         _FirstVerse = int.Parse(ColonSpliter[1]);
        //     }
        // }
        // else if (SpaceCounter == 2)
        // {
        //     _Book = SpaceSpliter[0];
        //     string[] ColonSpliter = SpaceSpliter[1].Split(":");
        //     _Chapter = int.Parse(ColonSpliter[0]);
        //     int VerseCounter = ColonSpliter[1].Count();
        // }
    }

    public void Display()
    {
        if (_lastVerse == 0)
        {
            Console.Write($"{_book} {_chapter}:{_firstVerse} ");
        }
        else
        {
            Console.Write($"{_book} {_chapter}:{_firstVerse}-{_lastVerse} ");
        }
    }
}