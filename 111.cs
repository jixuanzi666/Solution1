using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        int num1;
        while (!int.TryParse(Console.ReadLine(), out num1))
        {
        int num2;
        while (!int.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Invalid input. Please enter a valid number:");
        }
        }

        Console.WriteLine("Enter the second number:");
        int num2;
        while (!int.TryParse(Console.ReadLine(), out num2))
        {
        Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
        }

        int sum = AddNumbers(num1, num2);
        Console.WriteLine($"The sum is: {sum}");
    }

    static int AddNumbers(int a, int b)
    {
        return a + b;
    }
}