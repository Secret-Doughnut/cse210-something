using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Fraction Fire1 = new Fraction();
        Console.WriteLine(Fire1.GetFractionString());
        Console.WriteLine(Fire1.GetDecimalValue());

        Fraction Fire2 = new Fraction(5);
        Console.WriteLine(Fire2.GetFractionString());
        Console.WriteLine(Fire2.GetDecimalValue());

        Fraction Fire3 = new Fraction(3, 4);
        Console.WriteLine(Fire3.GetFractionString());
        Console.WriteLine(Fire3.GetDecimalValue());

        Fraction Fire4 = new Fraction(1, 3);
        Console.WriteLine(Fire4.GetFractionString());
        Console.WriteLine(Fire4.GetDecimalValue());
    }
}