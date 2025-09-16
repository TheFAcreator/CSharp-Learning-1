delegate int FibonacciNumbers();
class FibonacciNumbersRecurring
{
    static int num = 1;
    static int num2 = 1;
    static FibonacciNumbers del = delegate
    {
        int num3 = num + num2;
        num = num2;
        num2 = num3;
        return num;
    };
    static void Main(string[] args)
    {
        Console.WriteLine(1);
        for(int i = 0; i < 6; i++)
        {
            Console.WriteLine(del());
        }
    }
}