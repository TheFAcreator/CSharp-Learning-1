using System.Runtime.CompilerServices;

class Summary
{
    static void Main(string[] args)
    {
        int num, num2, sum;
        Console.Title = "Summary - number 1";
        Console.Write("Enter a number: ");
        num = int.Parse(Console.ReadLine());
        Console.Title = "Summary - nnumber 2";
        Console.Write("Enter a second number: ");
        num2 = int.Parse(Console.ReadLine());
        sum = num + num2;
        Console.WriteLine("Your summary is: " + sum);
    }
}