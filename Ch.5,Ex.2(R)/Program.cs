class NaturalNumbersDegreeRecursion
{
    static int NaturalNumbersDegree(int n, ref int sum1)
    {
        if (n == 0) return sum1;
        else
        {
            sum1 += n * n;
            n--;
            return NaturalNumbersDegree(n, ref sum1);
        }
    }
    static void Main(string[] args)
    {
        int n = 4;
        int sum1 = 0;
        int sum = NaturalNumbersDegree(n, ref sum1);
        Console.WriteLine(sum);
    }
}