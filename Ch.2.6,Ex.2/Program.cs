int num = default;

Thread isOdd = new(() =>
{
    for(int i = 0; i < 20; i++)
    {
        if (num % 2 != 0)
        {
            Console.WriteLine($"{num} is odd");
        }
        Thread.Sleep(900);
    }
});

Thread isDivisibleBy3 = new(() =>
{
    for(int i = 0; i < 20; i++)
    {
        if (num % 3 == 0)
        {
            Console.WriteLine($"{num} is divisible by 3");
        }
        Thread.Sleep(900);
    }
});

isOdd.Start();
isDivisibleBy3.Start();

Random random = new Random();
while (true)
{
    num = random.Next(1, 101);

    Thread.Sleep(1000);

    if (!(isOdd.IsAlive && isDivisibleBy3.IsAlive)) break;

}

Console.WriteLine("Num: " + num);