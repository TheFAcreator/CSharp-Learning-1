class FibonacciWhile
{
    static void Main(string[] args)
    {
        int cycle = 0, i = 0, num1 = 1, num2 = 1, num3;
        Console.Title = "Fibonacci numbers";
        try
        {
            Console.WriteLine("How many Fiboncci numbers do you wish to see?");
            cycle = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        catch
        {
            Console.WriteLine("You didn't enter a valid number.");
        }
        if (cycle > 0)
        {
            while (i < cycle)
            {
                num3 = num1 + num2;
                Console.WriteLine(num3 + " ");
                num1 = num2;
                num2 = num3;
                i++;
            }
        }
        else
        {
            Console.WriteLine("You didn\'t enter a valid number.");
        }
    }
}