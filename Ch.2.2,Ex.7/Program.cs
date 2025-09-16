delegate int Methods(int j);
class TooManyArguments
{
    static int[] ComplexMethod(int[] x, Methods del)
    {
        int[] ints = new int[x.Length];
        for (int i = 0; i < x.Length; i++)
        {
            ints[i] = del(x[i]);
        }
        return ints;
    }
    static int[] ints1 = {1, 2, 3};
    static int[] ints = ComplexMethod(ints1, delegate(int x)
    {
        return x * 3;
    });
    static int[] ints2 = ComplexMethod(ints1, x => x + 2);
    
    static void Main(string[] args)
    {
        foreach(int i in ints)
        {
            Console.WriteLine(i);
        }
        Console.WriteLine();
        foreach (int i in ints2)
        {
            Console.WriteLine(i);
        }
    }
}