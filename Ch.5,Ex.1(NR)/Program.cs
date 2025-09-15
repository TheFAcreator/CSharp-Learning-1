class DoubleFactorialNoRecursion
{
    static void DoubleFactorial(int a)
    {
        int sum = 1;
        int num = a;
        if (a % 2 == 0)
        {
            for (; num >= 2; num -= 2)
            {
                sum *= num;
            }
        }
        else
        {
            for (; num >= 1; num -= 2)
            {
                sum *= num;
            }
        }
        Console.WriteLine(sum);
    }
    static void Main(string[] args)
    {
        DoubleFactorial(5);
    }
}