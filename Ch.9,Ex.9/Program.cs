class BiggestElementSelection
{
    public int[,] ints;
    public BiggestElementSelection(int a, int b)
    {
        ints = new int[a, b];
        Random rnd = new Random();
        for (int i = 0; i < ints.GetLength(0); i++)
        {
            for (int j = 0; j < ints.GetLength(1); j++)
            {
                ints[i, j] = rnd.Next(1, 101);
            }
        }
    }
    public int this[int a, int b]
    {
        get
        {
            return ints[a, b];
        }
        set
        {
            ints[a, b] = value;
        }
    }
    public int this[int a]
    {
        get
        {
            int max = ints[a, 0];
            for (int i = 0; i < ints.GetLength(1); i++)
            {
                if (ints[a, i] > max) max = ints[a, i];
            }
            return max;
        }
        set
        {
            int max = ints[a, 0];
            int index = 0;
            for (int i = 0; i < ints.GetLength(1); i++)
            {
                if (ints[a, i] > max)
                {
                    max = ints[a, i];
                    index = i;
                }
            }
            ints[a, index] = value;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        BiggestElementSelection obj = new BiggestElementSelection(2, 4);
        for (int i = 0; i < obj.ints.GetLength(0); i++)
        {
            for (int j = 0; j < obj.ints.GetLength(1); j++)
            {
                Console.Write(obj.ints[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < obj.ints.GetLength(0); i++)
        {
            for (int j = 0; j < obj.ints.GetLength(1); j++)
            {
                Console.Write(obj[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        obj[1, 3] = 99;
        for (int i = 0; i < obj.ints.GetLength(0); i++)
        {
            for (int j = 0; j < obj.ints.GetLength(1); j++)
            {
                Console.Write(obj[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < obj.ints.GetLength(0); i++)
        {
            Console.WriteLine(obj[i]);
        }
        Console.WriteLine();
        obj[1] = 1;
        for (int i = 0; i < obj.ints.GetLength(0); i++)
        {
            for (int j = 0; j < obj.ints.GetLength(1); j++)
            {
                Console.Write(obj[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        for (int i = 0; i < obj.ints.GetLength(0); i++)
        {
            Console.WriteLine(obj[i]);
        }
        Console.WriteLine();
    }
}