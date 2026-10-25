using System;

class Program
{
    static void Main(string[] args)
    {
        RunMenu();
    }
    static void RunMenu()
    {
        Console.WriteLine("Choose a scripture:");
        Console.WriteLine("1. Proverbs 3:5-6");
        Console.WriteLine("2. John 3:16");
        Console.WriteLine("3. James 1:5");
        Console.Write("Enter your choice: ");
        string selection = Console.ReadLine();
        Reference reference;
        string text = "";
        if (selection == "1")
        {
            reference = new Reference("Proverbs", 3, 5, 6);
            text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";  
        }
        else if (selection == "2")
        {
            reference = new Reference("John", 3, 16);
            text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        }
        else if (selection == "3")
        {
            reference = new Reference("James", 1, 5);
            text = "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him.";
        }
        else
        {
            Console.WriteLine("Invalid selection");
            return;
        }

        Scripture scripture = new Scripture(reference, text);
        string choice = " ";
        while (choice != "quit")
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(scripture.GetScripture());
            if (scripture.IsCompletelyHidden() == true)
            {
                return;
            }
            Console.WriteLine("\nPress enter to hide words, or type 'quit' to finish: ");
            choice = Console.ReadLine();

            if (choice == "quit")
            {
                return;
            }
            if (choice == "")
            {
                scripture.HideWords(3);
            }
        }
    }
}