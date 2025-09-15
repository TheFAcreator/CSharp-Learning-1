class TwoGardeArray
{
    static void Main(string[] args)
    {
        int length = 10;
        int[] ints = new int[length];
        ints[0] = 1;
        for (int i = 1; i < ints.Length; i++) 
        {
            ints[i] = ints[i - 1] * 2;
        }
        foreach (int q in ints)
        {
            Console.Write(q + " ");
        }
        Console.WriteLine();
        for (int i = ints.Length - 1; i > -1; i--)
        {
            Console.Write(ints[i] + " ");
        }
    }
}