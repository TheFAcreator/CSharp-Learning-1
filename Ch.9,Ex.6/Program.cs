class NormalForIndexing
{
    int[] ints;
    int min;
    int max;
    public NormalForIndexing(int min, int max)
    {
        this.min = min;
        this.max = max;
        ints = new int[max - min];
        for (int i = 0; i < ints.Length; i++)
        {
            ints[i] = min + i;
        }
    }
    public int this[int index]
    {
        get
        {
            return ints[index - min];
        }
        set
        {
            ints[index - min] = value;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        int max = 2;
        int min = -8;
        NormalForIndexing obj = new NormalForIndexing(min, max);
        for (int i = min; i < max; i++)
        {
            Console.Write(obj[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine(obj[-6]);
        Console.WriteLine();
        obj[-1] = 9;
        for (int i = min; i < max; i++)
        {
            Console.Write(obj[i] + " ");
        }
        Console.WriteLine();
    }
}