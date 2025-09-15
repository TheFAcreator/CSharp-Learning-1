class EvenNumbersFor
{
    static void Main(string[] args)
    {
        int count = 10, i, sum = 0;
        Console.Write("2 + 4 + 6 +...+ {0} = ", 2 * count);
        for (i = 1; i <= count; i++)
        {
            sum += i * 2;
        }
        Console.WriteLine(sum);
    }
}