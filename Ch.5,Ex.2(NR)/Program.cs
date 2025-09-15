class DegreeNaturalNumbersNoRecursion
{
    static void naturalNumbersDegree(int a)
    {
        int sum = 0;
        for (int i = 1; i <= a; i++)
        {
            sum += i * i;
        }
        Console.Write(sum);
    }
    static void Main(string[] args)
    {
        int a = 4;
        Console.Write("Sum of the natural numbers between 1 and " + a + " = ");
        naturalNumbersDegree(a);
    }
}