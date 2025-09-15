class FibonacciNumbersFor
{
    static void Main(string[] args)
    {
        int decision = 0, num1 = 1, num2 = 1, num3;
        try
        {
            Console.WriteLine("How many Fibonacci numbers do you wish to see?");
            decision = int.Parse(Console.ReadLine());
            Console.Write("1, 1, ");
        }
        catch
        {
            Console.WriteLine("You didn\'t enter a valid number.");
        }
        for (int i = 0; i < decision-2; i++)
        {
            num3 = num1 + num2;
            Console.Write(num3 + ", ");
            num1 = num2;
            num2 = num3;
        }
        Console.Write("\b\b.");
    }
}