char[,] chars = new char[5, 10];

Thread[] colFillers = new Thread[chars.GetLength(1)];
for(int i = 0; i < colFillers.Length; i++)
{
    colFillers[i] = new Thread(col =>
    {
        Random rand = new Random();
        for (int row = 0; row < chars.GetLength(0); row++)
        {
            chars[row, (int)col] = (char)rand.Next('A', 'Z' + 1);
            Thread.Sleep(10); // simulate some delay
        }
    });
}

for (int i = 0; i < colFillers.Length; i++) // start all threads
{
    colFillers[i].Start(i);
}

for (int i = 0; i < colFillers.Length; i++) // wait for all threads to finish
{
    colFillers[i].Join();
}

for (int i = 0; i < chars.GetLength(0); i++) // print the array
{
    for (int j = 0; j < chars.GetLength(1); j++)
    {
        Console.Write(chars[i, j] + " ");
    }
    Console.WriteLine();
}


//static void FillArray(char[,] array)
//{
//    Random rand = new Random();
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//            array[i, j] = (char)rand.Next('A', 'Z' + 1);
//        }
//    }
//}
// alternative way to fill the array