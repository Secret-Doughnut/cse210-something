public class Scripture
{
    private static string _scripture = "Testing.";

    public Scripture()
    {

    }

    public Scripture(string text)
    {
        _scripture = text;
    }

    public void Display()
    {
        Console.WriteLine(_scripture);
    }

    public void SetScripture(string text)
    {
        _scripture = text;
    }

    public string GetScripture()
    {
        return _scripture;
    }
}