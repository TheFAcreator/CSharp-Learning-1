int[] ints = new int[21];
int start = 0;
int end = ints.Length - 1;

object lockObj = new();

int two = 2;
Thread powerOf2 = new Thread(() =>
{
    while (true)
    {
        lock (lockObj)
        {
            if (start >= end) break;
            ints[start++] = two;
            two *= 2;
        }

        Thread.Sleep(10);
    }
});

int three = 3;
Thread powerOf3 = new Thread(n =>
{
    while (true)
    {
        lock (lockObj)
        {
            if (start >= end) break;
            ints[end--] = three;
            three *= 3;
        }

        Thread.Sleep(10);
    }
});


powerOf2.Start();
powerOf3.Start();

powerOf2.Join();
powerOf3.Join();

foreach (var num in ints)
{
    Console.WriteLine(num);
}