// This program is actually with a while loop
class NumbersBetweenWhile
{
    static void Main(string[] args)
    {
        int num1, num2, i;
        Console.Title = "Numbers";
        Console.Write("Enter your first whole number: ");
        try
        {
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter your second number: ");
            num2 = int.Parse(Console.ReadLine());
            i = num1 + 1;
            do
            {
                Console.Write(i + " ");
                i++;
            }
            while (i < num2);
            Console.Write($"are all numbers between {num1} and {num2}.");
        }
        catch
        {
            Console.WriteLine("You didn\'t enter a whole number.");
        }
    }
}