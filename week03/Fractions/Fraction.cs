public class Fraction
{
    private int TopNumber = 1;

    private int BottomNumber = 1;

    public Fraction()
    {
        TopNumber = 1;
        BottomNumber = 1;
    }

    public Fraction(int ReturnedNumber)
    {
        TopNumber = ReturnedNumber;
        BottomNumber = 1;
    }

    public Fraction(int ReturnedTopNumber, int ReturnedBottomNumber)
    {
        TopNumber = ReturnedTopNumber;
        BottomNumber = ReturnedBottomNumber;
    }

    public int GetTop()
    {
        return TopNumber;
    }

    public void SetTop(int ReturnedTopNumber)
    {
        TopNumber = ReturnedTopNumber;
    }

    public int GetBottom()
    {
        return BottomNumber;
    }

    public void SetBottom(int ReturnedBottomNumber)
    {
        BottomNumber = ReturnedBottomNumber;
    }

    public string GetFractionString()
    {
        return $"{TopNumber}/{BottomNumber}";
    }

    public double GetDecimalValue()
    {
        double DividedAnswer = (Double) TopNumber / (Double) BottomNumber;
        return DividedAnswer;
    }
}