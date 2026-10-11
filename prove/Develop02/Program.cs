using System;

// To exceed requirements, I added code to ask the user if they would like to save before quitting. 
// I also added code to handle incorrect inputs that are not 1-5
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        RunMenu();
    }

    static void RunMenu()
    {
        Journal journal = new Journal();
        int  choice = 0;

        while (choice != 5)
        {
            Console.Write("""

            Please select one of the following choices:
            1. Write
            2. Display
            3. Load
            4. Save
            5. Quit
            What would you like to do? 
            """);
            if(!int.TryParse(Console.ReadLine(), out choice))
            {
                
            }
            if (choice == 1)
            {
                journal.AddEntry();
            } 
            else if (choice == 2)
            {
                journal.DisplayEntries();
            }
            else if (choice == 3)
            {
                journal.LoadFromFile();
            }
            else if (choice == 4)
            {
                journal.SaveToFile();
            }
            else if (choice == 5)
            {
                //Allows the user to save the file before quitting
                string saveChoice;
                Console.Write("Would you like to save? y/n ");
                saveChoice = Console.ReadLine().ToLower();
                if (saveChoice == "y")
                {
                    journal.SaveToFile();
                    Console.WriteLine("Goodbye!");
                }
                else if (saveChoice == "n")
                {
                    Console.WriteLine("Goodbye!");
                }
                else
                {
                    Console.WriteLine("Input not recognized");
                    choice = 0;
                }
            }
            else
            {
                Console.WriteLine("Invalid response, please type only 1-5.");
            }
        } 
    }
}