class NumberSquare
{
    static void Main(string[] args)
    {
        int k = 10, num = 1, sum;
        for (int i = 0; i < k; i++)
        {
            sum = num * num;
            Console.Write(sum + ", ");
            num += 1;
        }
        Console.Write("\b\b.");
        Console.WriteLine();
    }
}