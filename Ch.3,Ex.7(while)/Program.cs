class NumbersSquareSumWhile
{
    static void Main(string[] args)
    {
        int num = 1, i = 0, k = 10, sum = 0;
        while (i < k)
        {
            sum += num * num;
            num++;
            i++;
        }
        Console.WriteLine("1^2 + 2^2 + 3^2 + ... 10^2 = " + sum);
    }
}