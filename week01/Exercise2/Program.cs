using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);

        string letter = "";
        string sign = "";
        if (grade >= 97) { letter = "A"; sign = "+"; }
        else if (grade >= 93) { letter = "A"; sign = ""; }
        else if (grade >= 90) { letter = "A"; sign = "-"; }
        else if (grade >= 87) { letter = "B"; sign = "+"; }
        else if (grade >= 83) { letter = "B"; sign = ""; }
        else if (grade >= 80) { letter = "B"; sign = "-"; }
        else if (grade >= 77) { letter = "C"; sign = "+"; }
        else if (grade >= 73) { letter = "C"; sign = ""; }
        else if (grade >= 70) { letter = "C"; sign = "-"; }
        else if (grade >= 67) { letter = "D"; sign = "+"; }
        else if (grade >= 63) { letter = "D"; sign = ""; }
        else if (grade >= 60) { letter = "D"; sign = "-"; }
        else if (grade >= 57) { letter = "F"; sign = "-"; }
        else if (grade >= 53) { letter = "F"; sign = "+"; }
        else { letter = "F"; sign = ""; }

        if (grade >= 93)
        {
        Console.WriteLine($"Your grade is {letter}.");
        }
        else if (grade <= 59)
        {
        Console.WriteLine($"Your grade is {letter}.");
        }
        else{
        Console.WriteLine($"Your grade is {letter}{sign}.");
        }
        
        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("You failed!");
        }


    }
}