class ArrayDescendingSort
{
    static void Main(string[] args)
    {
        int s;
        int[] ints = new int[10];
        Random rnd = new Random();
        for (int i = 0; i < ints.Length; i++)
        {
            ints[i] = rnd.Next(0, 101);
        }
        for (int i = 0; i < ints.Length; i++)
        {
            Console.Write(ints[i] + " ");
        }
        Console.WriteLine();
        for (int i = 1; i < ints.Length; i++)
        {
            for (int j = 0; j < ints.Length-i; j++)
            {
                if (ints[j] < ints[j + 1])
                {
                    s = ints[j];
                    ints[j] = ints[j + 1];
                    ints[j + 1] = s;
                }
            }
        }
        for (int i = 0; i < ints.Length; i++)
        {
            Console.Write(ints[i] + " ");
        }
    }
}