class AverageValueIntArray 
{
    static int AverageValue(int[] a)
    {
        int sum = 0;
        for (int i = 0; i < a.Length; i++)
        {
            sum += a[i];
        }
        return sum / a.Length;
    }
    static void Main(string[] args)
    {
        int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int averageValue = AverageValue(a);
        Console.WriteLine(averageValue);
    }    
}