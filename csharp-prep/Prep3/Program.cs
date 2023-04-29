using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        //Console.Write("What is the magic number? ");
        //int magicNumber = Console.ReadLine();
        int yourNumber = -1;
        while (yourNumber != magicNumber)
        {
            Console.Write("What is your guess? ");
            yourNumber = int.Parse(Console.ReadLine());
            if (yourNumber == magicNumber)
            {
                Console.WriteLine("You guessed it!");
                Console.Write("Do you want to play again? ");
                string response = Console.ReadLine();
                if (response == "yes")
                {
                    while (yourNumber != magicNumber)
                    {
                        Console.Write("What is your guess? ");
                        yourNumber = int.Parse(Console.ReadLine());
                    }
                }
                else
                {
                    Console.WriteLine("Thank you for playing the guess game. ");
                }
            }
            else if (yourNumber < magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (yourNumber > magicNumber)
            {
                Console.WriteLine("Higher");
            }
        }
    }
}