using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        //A function to DisplayWelcome - Displays the message, "Welcome to the Program!"
        void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        // Call the DisplayWelcome function
        DisplayWelcome();

        //A function to PromptUserName - Asks for and returns the user's name (as a string)
        string PromptUserName()
        {
            Console.Write("Enter your name: ");
            String userName = Console.ReadLine();
            return userName;
        }
        // Call the PromptUserName function and store the result in a variable
        string userName = PromptUserName();
        Console.WriteLine($"Hello, Brother {userName}!");

        //A function to PromptUserNumber - Asks for and returns the user's favorite number (as an integer)
        int PromptUserNumber()
        {
            Console.Write("Enter your favorite number: ");
            int num = int.Parse(Console.ReadLine());
            return num;
        }
        // Call the PromptUserNumber function and store the result in a variable
        int userNumber = PromptUserNumber();
        Console.WriteLine($"Your favorite number is: {userNumber}");

        //A function to SquareNumber - Accepts an integer as a parameter and returns that number squared (as an integer)
        int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }
        // Call the SquareNumber function and store the result in a variable    
        int squaredNumber = SquareNumber(userNumber);
        Console.WriteLine($"The square of your favorite number is: {squaredNumber}");

        //A function that DisplayResult - Accepts the user's name and the squared number and displays them.
        void DisplayResult(string name, int number)
        {
            Console.WriteLine($"Hello, {name}! The square of your favorite number is: {number}");
        }
        // Call the DisplayResult function
        DisplayResult(userName, squaredNumber);
    }
}