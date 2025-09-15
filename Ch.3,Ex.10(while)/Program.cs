class SummarizingStrangeNumbersUsingWhile
{
    static void Main(string[] args)
    {
            Console.WriteLine("Enter a number (it will determine how many numbers will be summarized):");
        try {
            int count = int.Parse(Console.ReadLine());
            int num = 1;
            int nums = 0;
            int sum = 0;
            Console.WriteLine("Numbers added to sum:");
            while (nums < count)
            {
                if (num % 5 == 2)
                {
                    nums++;
                    sum += num;
                    Console.WriteLine(num);

                }
                else if (num % 3 == 1)
                {
                    nums++;
                    sum += num;
                    Console.WriteLine(num);
                }
                num++;
            }
            Console.WriteLine("Sum: " + sum);
        }
        catch
        {
            Console.WriteLine("The input you entered is invalid. Please enter a positive number.");
        }
    }
}