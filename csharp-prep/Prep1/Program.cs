using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the users for their first name.
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();

        //Now ask for their last name.
        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        //print a blank line.
        Console.WriteLine("");

        //Now print out their full name.
        Console.Write($"Your name is {last}, {first} {last}.");
    }
}