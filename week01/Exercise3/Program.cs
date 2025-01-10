using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        /*Console.Write("What is the magic number? ");
        string magicNumber = Console.ReadLine();
        int magic = int.Parse(magicNumber);

        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int guessNumber = int.Parse(guess);*/

        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);
        int guessNumber = 0;
        
        string Response = "Y";
        int count = 1;
        do
        {
            do
            {
                Console.Write("What is your guess? ");
                guessNumber = int.Parse(Console.ReadLine());
                count++;
                if (magic == guessNumber)
                {
                    Console.WriteLine($"Congratulations! You guessed the magic number in {count} guesses.");
                }
                else if (magic < guessNumber)
                {
                    Console.WriteLine("Lower.");
                }
                else if (magic > guessNumber)
                {
                    Console.WriteLine("Higher.");
                }
            } while (magic != guessNumber);
            Console.Write("Do you want to play again? (Y/N) ");
            Response = Console.ReadLine();
        }   while (Response == "Y");
    }
}