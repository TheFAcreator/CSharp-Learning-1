class RemoveColRowRandom
{
    static void Main(string[] args)
    {
        int row, col;
        int[,] ints = { { 1, 2, 3, 4, 5, 6, 7 }, { 8, 9, 10, 11, 12, 13, 14 }, { 15, 16, 17, 18, 19, 20, 21 } };
        Random rnd = new Random();
        row = rnd.Next(0 + ints.GetLength(0));
        col = rnd.Next(0 + ints.GetLength(1));
        int[,] ints2 = new int[ints.GetLength(0) - 1, ints.GetLength(1) - 1];
        for (int i = 0; i < ints.GetLength(0); i++)
        {
            for (int j = 0; j < ints.GetLength(1); j++)
            {
                Console.Write(ints[i, j] + " ");
            }
            Console.WriteLine();
        }
        for (int i = 0, i2 = 0; i2 < ints2.GetLength(0); i++)
        {
            if (i != row)
            {
                for (int j = 0, j2 = 0; j2 < ints2.GetLength(1); j++)
                {
                    if (j != col)
                    {
                        ints2[i2, j2] = ints[i, j];
                        j2++;
                    }
                }
                i2++;
            }
        }
        Console.WriteLine();
        for (int i = 0; i < ints2.GetLength(0); i++)
        {
            for (int j = 0; j < ints2.GetLength(1); j++)
            {
                Console.Write(ints2[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}