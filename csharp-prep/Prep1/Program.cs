using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the users for their first name.
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();

        //Now ask for their last name.
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();
        Console.WriteLine("");

        //Now print out their full name.
        Console.Write($"Your name is {lastName}, {firstName} {lastName}.");
    }
}