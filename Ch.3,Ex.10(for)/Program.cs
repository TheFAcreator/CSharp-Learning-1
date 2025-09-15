
class SummarizingStrangeNumbersUsingFor
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number (it will determine how many numbers will be summarized):");
        try
        {
            int count = int.Parse(Console.ReadLine());
            int sum = 0;
            int num = 0;
            Console.WriteLine("Numbers added to sum:");
            for (int nums = 1; num < count; nums++)
            {
                if (nums % 5 == 2)
                {
                    sum += nums;
                    num++;
                    Console.WriteLine(nums);
                }
                else if (nums % 3 == 1)
                {
                    sum += nums;
                    num++;
                    Console.WriteLine(nums);
                }
            }
            Console.WriteLine("Sum: " + sum);
        }
        catch
        {
            Console.WriteLine("The input you entered is invalid. Please enter a positive number.");
        }
    }
}