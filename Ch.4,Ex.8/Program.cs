using System.Globalization;

class TwoDimArrayInvertion
{
    static void Main(string[] args)
    {
        int rows = 3, cols = 5;
        int[,] ints = new int[rows, cols];
        int[,] ints2 = new int[cols, rows];
        Random rnd = new Random();
        for (int i = 0; i < ints.GetLength(0); i++)
        {
            for (int j = 0; j < ints.GetLength(1); j++)
            {
                ints[i, j] = rnd.Next(1, 101);
            }
        }
        for (int i = 0; i < ints.GetLength(0); i++)
        {
            for (int j = 0; j < ints.GetLength(1); j++)
            {
                Console.Write(ints[i, j] + " | ");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < ints2.GetLength(0); i++)
        {
            for (int j = 0; j < ints2.GetLength(1); j++)
            {
                ints2[i, j] = ints[j, i];
            }
        }
        for (int i = 0; i < ints2.GetLength(0); i++)
        {
            for (int j = 0; j < ints2.GetLength(1); j++)
            {
                Console.Write(ints2[i, j] + " | ");
            }
            Console.WriteLine();
        }
    }
}