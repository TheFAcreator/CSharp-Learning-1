class OnlyOddNumbers
{
    private static int num;
    public static int Number
    {
        get
        {
                int s = num;
                num += 2;
                return s;
        }
        set
        {
            if (value != 1)
            {
                num = 1;
                for (int i = 0; i < value - 1; i++)
                {
                    num += 2;
                }
            }
            else
            {
                num = value;
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        OnlyOddNumbers.Number = 1;
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(OnlyOddNumbers.Number);
        }
        OnlyOddNumbers.Number = 2;
        Console.WriteLine(OnlyOddNumbers.Number);
    }
}