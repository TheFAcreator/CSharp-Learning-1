class ArraySnakeFilling
{
    static bool FillToRight(int i)
    {
        for (int k = i; k < snakeArray.GetLength(1) - i; k++)
        {
            if (indexed >= count) return true;
            if (snakeArray[i, k] == 0)
            {
                snakeArray[i, k] = num++;
                indexed++;
            }
        }
        return false;
    }
    static bool FillToBottom(int i)
    {
        int j = snakeArray.GetLength(1) - i - 1;
        for (int k = i + 1; k < snakeArray.GetLength(0) - i; k++)
        {
            if (indexed >= count) return true;
            if (snakeArray[k, j] == 0)
            {
                snakeArray[k, j] = num++;
                indexed++;
            }
        }
        return false;
    }
    static bool FillToLeft(int i)
    {
        int j = snakeArray.GetLength(0) - i - 1;
        for (int k = snakeArray.GetLength(1) - i - 2; k >= i; k--)
        {
            if (indexed >= count) return true;
            if (snakeArray[j, k] == 0)
            {
                snakeArray[j, k] = num++;
                indexed++;
            }
        }
        return false;
    }
    static bool FillToTop(int i)
    {
        for (int k = snakeArray.GetLength(0) - i - 2; k > i; k--)
        {
            if (indexed >= count) return true;
            if (snakeArray[k, i] == 0)
            {         
                snakeArray[k, i] = num++;
                indexed++;
            }
        }
        return false;
    }

    static int[,] snakeArray = new int[4, 5];
    static int count = snakeArray.Length;
    static int indexed = 0;
    static int num = 1;

    static void Main(string[] args)
    {
        for (int i = 0; indexed < count; i++)
        {
            if (FillToRight(i)) return;
            if (FillToBottom(i)) return;
            if (FillToLeft(i)) return;
            if (FillToTop(i)) return;
        }
        for (int i = 0; i < snakeArray.GetLength(0); i++)
        {
            for(int j = 0;  j < snakeArray.GetLength(1); j++)
            {
                Console.Write(snakeArray[i, j] + " ");
            }
            Console.WriteLine();
        }
        /* Output:
          1  2  3  4  5
          14 15 16 17 6
          13 20 19 18 7
          12 11 10 9 8
         */
    }
}