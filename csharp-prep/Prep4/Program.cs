using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;
        List<int> numbers;
        numbers = new List<int>();
        do
        {
            Console.Write("Enter Number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);
        int sum = 0;
        int largest = numbers[1];
        float average;
        foreach (int item in numbers)
        {
            sum += item;
            if (item > largest)
            {
                largest = item;
            }
        }
        average = (float)sum / numbers.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}