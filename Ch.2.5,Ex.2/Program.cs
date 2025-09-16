class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        int? num1 = null;
        try
        {
            num1 = int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Input for first number is not valid.");
            Console.WriteLine();

            Main(args);
        }

        Console.Write("Enter second number: ");
        int? num2 = null;
        try
        {
            num2 = int.Parse(Console.ReadLine());
        }
        catch
        {
            Console.WriteLine("Input for second number is not valid.");
            Console.WriteLine();

            Main(args);
        }

        try
        {
            int max = Math.Max((int)num1, (int)num2);
            int min = Math.Min((int)num1, (int)num2);

            Console.WriteLine(max + " % " + min + " == " + max % min);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine((num1 < num2 ? "First" : "Second") + " number is zero. Cannot divide by zero.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        finally
        {
            Console.WriteLine();
            Main(args);
        }
    }
}