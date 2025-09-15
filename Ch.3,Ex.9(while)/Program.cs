using Microsoft.VisualBasic;
// This project actually uses for loop
class NumberbetweenWhile
{
    static void Main(string[] args)
    {
        int num1, num2;
        Console.WriteLine("Enter your first number");
        try
        {
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("\nResult:");
                for (int i = num2; i < num1; i++)
                {
                    Console.WriteLine(i + " ");
                }
            }
            else if (num1 < num2)
            {
                Console.WriteLine("\nResult:");
                for (int i = num1; i < num2; ++i)
                {
                    Console.WriteLine(i + " ");
                }
            }
            else
            {
                Console.WriteLine($"Your number are equal. ({num1})");
            }
        }
        catch
        {
            Console.WriteLine("You didn\'t enter a valid number.");
        }
    }
}