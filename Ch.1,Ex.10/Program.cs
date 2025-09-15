
using System;
class SumAndExtracted
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your first number: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your second number: ");
        int num2 = int.Parse(Console.ReadLine());
        int sum = num1 + num2;
        int extracted = num1 - num2;
        Console.WriteLine("The sum of your numbers is: " + sum + "\nThe extraction of your numbers (first number minus second number) is: " + extracted);
    }
}
