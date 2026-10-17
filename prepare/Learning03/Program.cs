using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction();
        Random random = new Random();
        for (int i = 0; i < 20; i++)
        {
            fraction.SetTop(random.Next(1, 100));
            fraction.SetBottom(random.Next(1,100));
            Console.WriteLine($"Fraction {i+1}: string: {fraction.GetFractionString()} Number: {fraction.GetDecimalValue()}");
        }
    }
}