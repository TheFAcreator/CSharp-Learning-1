int[] ints = new int[15];

Random random = new Random();
for (int i = 0; i < ints.Length; i++)
{
    ints[i] = random.Next(0, 101);
}

Thread max = new Thread(() => Console.WriteLine(ints.Max()));

Thread min = new Thread(() => Console.WriteLine(ints.Min()));

max.Start();
min.Start();

max.Join();
min.Join();

for (int i = 0; i < ints.Length; i++)
{
    Console.Write(ints[i] + " ");
}

/*
   Example output:
    100
    0
    72 61 50 40 0 26 1 100 4 89 64 14 83 46 36
*/