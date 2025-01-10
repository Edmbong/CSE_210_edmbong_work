using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        
        List<double> numbers = new List<double>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int sum = 0;
        int Count = 0;
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        numbers.Add(number);
        while (number != 0)
        {
            sum += number;
            Console.Write("Enter a number: ");
            input = Console.ReadLine();
            number = int.Parse(input);
            Count++;   
        }
        double Max = numbers.Max();
        double Min = numbers.Min();
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The nunber of numbers entered is: {Count}");
        Console.WriteLine($"The average is: {sum / Count}");
        Console.WriteLine($"The maximum number is: {Max}");
        Console.WriteLine($"The minimum number is: {Min}");

        numbers.Sort();
            Console.WriteLine("Sorted List:");
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
        
    

    }
}