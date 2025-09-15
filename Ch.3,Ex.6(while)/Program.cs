class EvenNumbersSumWhile
{
    static void Main(string[] args)
    {
        int num = 2, i = 0, k = 10, sum = 0;
        while (i < k)
        {
            sum += num;
            num += 2;
            i++;
        }
        Console.WriteLine($"2 + 4 + 6 + ... + 20 = {sum}");
    }
}