int[,] ints = new int[5, 4];

Thread[] threads = new Thread[ints.GetLength(0)];

for (int i = 0; i < threads.Length; i++)
{
    int row = i;
    if (i % 2 == 0)
    {
        threads[i] = new Thread(() =>
        {
            int powerOf2 = 1;
            for (int j = 0; j < ints.GetLength(1); j++)
            {
                ints[row, j] = powerOf2 *= 2;
            }
        });
    }
    else
    {
        threads[i] = new Thread(() =>
        {
            int powerOf3 = 1;
            for (int j = 0; j < ints.GetLength(1); j++)
            {
                ints[row, j] = powerOf3 *= 3;
            }
        });
    }
}

foreach (Thread thread in threads)
{
    thread.Start();
}

while (threads.Any(t => t.IsAlive)) ;

for (int i = 0; i < ints.GetLength(0); i++)
{
    for (int j = 0; j < ints.GetLength(1); j++)
    {
        Console.Write(ints[i, j] + " ");
    }
    Console.WriteLine();
}