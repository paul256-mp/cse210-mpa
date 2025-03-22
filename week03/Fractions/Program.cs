using System;

public class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction(1, 2);
        Console.WriteLine(f1.getFractionString());
        Console.WriteLine(f1.getDecimalValue());

        Fraction f2 = new Fraction(3);
        Console.WriteLine(f2.getFractionString());
        Console.WriteLine(f2.getDecimalValue());

        Fraction f3 = new Fraction(3, 4);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        Fraction f4 = new Fraction(3, 4);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
    }
}