class BiggestElementOut
{
    static int biggestElement(int[,] ints, out int index1, out int index2)
    {
        int value = ints[0, 0];
        index1 = 0;
        index2 = 0;
        for (int i = 0; i < ints.GetLength(0); i++)
            {
            for (int j = 0; j < ints.GetLength(1); j++)
            {
                if (ints[i, j] > value)
                {
                    value = ints[i, j];
                    index1 = i;
                    index2 = j;
                }
            }
        }
        Console.Write("Index 1: " + index1 + "; index 2: " + index2);
        Console.WriteLine();
        return value;
    }
    static void Main(string[] args)
    {
        int element, index1, index2;
        int[,] ints = { { 3, 78, 93, 02 }, { 4, 8, 96, 23 } };
        element = biggestElement(ints, out index1, out index2);
        Console.WriteLine("Value: " + element);
    }
}