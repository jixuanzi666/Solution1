using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int num2 = int.Parse(Console.ReadLine());

        int sum = AddNumbers(num1, num2);
        Console.WriteLine($"The sum is: {sum}");
    }

    static int AddNumbers(int a, int b)
    {
        return a + b;
    }
}