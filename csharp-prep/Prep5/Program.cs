using System;

class Program
{
    static void Main(string[] args)
    {
        int birthYear;
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        PromptUserBirthYear(out birthYear);
        int numberSquared = SquareNumber(userNumber);
        DisplayResult(userName, numberSquared, birthYear);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }
    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int userNumber)
    {
        int numberSquared = userNumber * userNumber;
        return numberSquared;
    }
    static void DisplayResult(string userName, int numberSquared, int birthYear)
    {
        int currentYear = DateTime.Now.Year;
        int userAge = currentYear - birthYear;
        Console.WriteLine($"{userName},  the square of your number is {numberSquared}");
        Console.WriteLine($"{userName}, you will turn {userAge} this year.");
    }
}