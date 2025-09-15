class DoubleFactorialRecursion
{
    static void DoubleFactorialEven(int a, ref int i, ref int sum)
    {
        if (i != 0)
        {
            sum *= a;
            i -= 2;
            DoubleFactorialEven(a - 2, ref i, ref sum);
        }
        else
        {
            Console.WriteLine(sum);
        }
    }
    static void DoubleFactorialOdd(int a, ref int i, ref int sum)
    {
        if (i != 1)
        {
            sum *= a;
            i -= 2;
            DoubleFactorialOdd(a - 2, ref i, ref sum);
        }
        else
        {
            Console.WriteLine(sum);
        }
    }
    static void Main(string[] args)
    {
        int num = 6;
        int i = num;
        int sum = 1;
        Console.Write($"Double factorial for {num}: ");
        if (num % 2 == 0)
        {
            DoubleFactorialEven(num, ref i, ref sum);
        }
        else
        {
            DoubleFactorialOdd(num, ref i, ref sum);
        }
    }
}